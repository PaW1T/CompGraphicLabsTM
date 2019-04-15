using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Lab3 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private List<Shape> additionalShapes;
        private List<Bezie> parabolas;
        private List<Bezie> parabolaStart;
        private List<Bezie> parabolasEnd;
        private int[] pointToConnect;
        private float step = 10;
        private int activeControl = -1;
        private int currentIndex = 0;
        private int indexToRemove = -1;
        private bool readyToConnect = false;
        private int activeDot;

        public Lab3()
        {
            InitializeComponent();

            additionalShapes = new List<Shape>();
            parabolas = new List<Bezie>();
            graphics = pictureBox1.CreateGraphics();
        }
        private void Animation()
        {
            float delta = 1f;
            bool isChanged = false, isEnd = true;

            List<PointF> pPoints = new List<PointF>();
            for (int i = 0; i < parabolas.Count - 1; i++)
            {
                isChanged = false;
                for (int j = 0; j < 6; j++)
                {
                    float px = parabolas[i].Points[j].X, py = parabolas[i].Points[j].Y;
                    if (!(parabolas[i].Points[j].X > parabolasEnd[i].Points[j].X - delta && parabolas[i].Points[j].X < parabolasEnd[i].Points[j].X + delta))
                    {
                        if (parabolas[i].Points[j].X > parabolasEnd[i].Points[j].X)
                        {
                            px = parabolas[i].Points[j].X - (parabolaStart[i].Points[j].X - parabolasEnd[i].Points[j].X) / step;
                        }
                        else
                        {
                            px = parabolas[i].Points[j].X + (parabolasEnd[i].Points[j].X - parabolaStart[i].Points[j].X) / step;
                        }
                        isChanged = true;
                    }

                    if (!(parabolas[i].Points[j].Y > parabolasEnd[i].Points[j].Y - delta && parabolas[i].Points[j].Y < parabolasEnd[i].Points[j].Y + delta))
                    {
                        if (parabolas[i].Points[j].Y > parabolasEnd[i].Points[j].Y)
                        {
                            py = parabolas[i].Points[j].Y - (parabolaStart[i].Points[j].Y - parabolasEnd[i].Points[j].Y) / step;
                        }
                        else
                        {
                            py = parabolas[i].Points[j].Y + (parabolasEnd[i].Points[j].Y - parabolaStart[i].Points[j].Y) / step;

                        }
                        isChanged = true;
                    }
                    pPoints.Add(new PointF(px, py));
                }
                if (isChanged)
                {
                    parabolas[i] = new Bezie(pPoints.ToArray(), parabolas[i].Index);
                }
                isEnd = isEnd && !isChanged;
                pPoints.Clear();
            }
            if (isEnd)
            {
                timer1.Stop();
            }
        }

        

        private void drawbutton_Click(object sender, EventArgs e)
        {
            parabolas.Clear();
            currentIndex = 0;
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"E:\4 курс\Graphics\Laba3\line1.txt"))
            {
                while (!file.EndOfStream)
                    parabolas.Add(new Bezie(file.ReadLine(), currentIndex++));
                file.Close();
            }
            pictureBox1.Refresh();
        }

        private void animatebutton_Click(object sender, EventArgs e)
        {
            List<Bezie> p2 = new List<Bezie>();
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"E:\4 курс\Graphics\Laba3\line2.txt"))
            {
                while (!file.EndOfStream)
                    p2.Add(new Bezie(file.ReadLine(), currentIndex++));
                file.Close();
            }
            parabolaStart = parabolas;
            parabolasEnd = p2;
            timer1.Start();
        }
        private void ShowDotsCheck_Changed(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void Time_Plus(object sender, EventArgs e)
        {
            Animation();
            pictureBox1.Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in additionalShapes)
            {
                item.Draw(e.Graphics);
            }
            foreach (var item in parabolas)
            {
                item.Draw(e.Graphics, ShowDotsCheck.Checked);
            }
        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (readyToConnect)
            {
                if (parabolas.Count > 0)
                {
                    foreach (var item in parabolas)
                    {
                        for (var i = 0; i < 6; i += 2)
                        {
                            if (e.X + 5 > item.Points[i].X && e.X - 5 < item.Points[i].X)
                            {
                                if (e.Y + 5 > item.Points[i].Y && e.Y - 5 < item.Points[i].Y)
                                {
                                    if (pointToConnect[0] < 0)
                                    {
                                        pointToConnect[0] = item.Index;
                                        pointToConnect[1] = i;
                                    }
                                    else
                                    {
                                        parabolas[pointToConnect[0]].Points[pointToConnect[1]] = item.Points[i];
                                        pictureBox1.Refresh();
                                        readyToConnect = false;
                                        pointToConnect = new int[] { -1, -1 };
                                        
                                    }
                                    break;
                                }
                            }
                        }
                        if (!readyToConnect)
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (parabolas.Count > 0)
            {
                foreach (var item in parabolas)
                {
                    for (var i = 0; i < 6; i++)
                    {
                        if (e.X + 5 > item.Points[i].X && e.X - 5 < item.Points[i].X)
                        {
                            if (e.Y + 5 > item.Points[i].Y && e.Y - 5 < item.Points[i].Y)
                            {
                                activeDot = i;
                                activeControl = item.Index;
                                indexToRemove = item.Index;
                                break;
                            }
                        }
                    }
                    if (activeControl >= 0)
                    {
                        break;
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = (e.X).ToString();
            labelY.Text = (e.Y).ToString();
            if (activeControl >= 0)
            {
                float x = 0f, y = 0f;
                if (e.X < 0)
                {
                    x = 0;
                }
                else
                {
                    if (e.X > pictureBox1.Width)
                    {
                        x = pictureBox1.Width;
                    }
                    else
                    {
                        x = e.X;
                    }
                }

                if (e.Y < 0)
                {
                    y = 0;
                }
                else
                {
                    if (e.Y > pictureBox1.Height)
                    {
                        y = pictureBox1.Height;
                    }
                    else
                    {
                        y = e.Y;
                    }
                }

                parabolas[activeControl].Points[activeDot] = new PointF(x, y);

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (activeControl >= 0)
            {
                activeControl = -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
