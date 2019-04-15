using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;
        private Pen figurePen;
        private Point center;
        private List<Line3D> lines;
        private Bitmap bm;
        private int axisLength;
        private int unit;
        private double alpha;
        private double beta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            center = new Point(pictureBox1.Width / 2 - 100, pictureBox1.Height / 2 - 30);
            axisLength = 300;
            unit = 10;

            pen = new Pen(Color.Black, 1);
            figurePen = new Pen(Color.Red, 3);
        }

        private void InitBitmap()
        {
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        }

        private void DrawAxis()
        {
            Point[] ends = new[] {
                new Point3D(axisLength, 0, 0),
                new Point3D(0, axisLength, 0),
                new Point3D(0, 0, axisLength)
            }.Select(p => p.Projection(alpha, beta, center)).ToArray();

            Font font = new Font(FontFamily.GenericSansSerif, 14);
            Brush brush = new SolidBrush(Color.Black);
            string[] labels = new[] { "X", "Y", "Z" };

            for (int i = 0; i < ends.Length; i++)
            {
                g.DrawLine(pen, center, ends[i]);
                g.DrawString(labels[i], font, brush, ends[i]);
            }

            new Line3D(new Point3D(-Normalize(1) / 5, Normalize(0), Normalize(1)), new Point3D(Normalize(1) / 5, Normalize(0), Normalize(1)))
                .Draw(g, alpha, beta, center);
            new Line3D(new Point3D(Normalize(1), Normalize(0), Normalize(1) / 5), new Point3D(Normalize(1), Normalize(0), -Normalize(1) / 5))
                .Draw(g, alpha, beta, center);
            new Line3D(new Point3D(-Normalize(1) / 5, Normalize(1), Normalize(0)), new Point3D(Normalize(1) / 5, Normalize(1), Normalize(0)))
                .Draw(g, alpha, beta, center);

            font = new Font(FontFamily.GenericSansSerif, 10);
            g.DrawString(unit.ToString(), font, brush, new Point3D(Normalize(1) / 5, Normalize(0), Normalize(1)).Projection(alpha, beta, center));
            g.DrawString(unit.ToString(), font, brush, new Point3D(Normalize(1), Normalize(0), -Normalize(1) / 5).Projection(alpha, beta, center));
            g.DrawString(unit.ToString(), font, brush, new Point3D(Normalize(1) / 5, Normalize(1), Normalize(0)).Projection(alpha, beta, center));
        }

        private void DrawHouse()
        {
            //top
            DrawLine(new Point3D(Normalize(8), Normalize(4), Normalize(3)), new Point3D(Normalize(10), Normalize(4), Normalize(5)));
            DrawLine(new Point3D(Normalize(10), Normalize(4), Normalize(5)), new Point3D(Normalize(13), Normalize(4), Normalize(5)));
            DrawLine(new Point3D(Normalize(13), Normalize(4), Normalize(5)), new Point3D(Normalize(12), Normalize(4), Normalize(8)));
            DrawLine(new Point3D(Normalize(12), Normalize(4), Normalize(8)), new Point3D(Normalize(13), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(12), Normalize(4), Normalize(8)), new Point3D(Normalize(13), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(13), Normalize(4), Normalize(11)), new Point3D(Normalize(10), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(10), Normalize(4), Normalize(11)), new Point3D(Normalize(8), Normalize(4), Normalize(13)));
            DrawLine(new Point3D(Normalize(8), Normalize(4), Normalize(13)), new Point3D(Normalize(8), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(8), Normalize(4), Normalize(11)), new Point3D(Normalize(3), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(3), Normalize(4), Normalize(11)), new Point3D(Normalize(5), Normalize(4), Normalize(8)));
            DrawLine(new Point3D(Normalize(5), Normalize(4), Normalize(8)), new Point3D(Normalize(3), Normalize(4), Normalize(5)));
            DrawLine(new Point3D(Normalize(3), Normalize(4), Normalize(5)), new Point3D(Normalize(8), Normalize(4), Normalize(5)));
            DrawLine(new Point3D(Normalize(8), Normalize(4), Normalize(5)), new Point3D(Normalize(8), Normalize(4), Normalize(3)));

            //bottom

                DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(3)), new Point3D(Normalize(10), Normalize(0), Normalize(5)));
                DrawLine(new Point3D(Normalize(10), Normalize(0), Normalize(5)), new Point3D(Normalize(13), Normalize(0), Normalize(5)));
                DrawLine(new Point3D(Normalize(13), Normalize(0), Normalize(5)), new Point3D(Normalize(12), Normalize(0), Normalize(8)));
                DrawLine(new Point3D(Normalize(12), Normalize(0), Normalize(8)), new Point3D(Normalize(13), Normalize(0), Normalize(11)));
         //       DrawLine(new Point3D(Normalize(12), Normalize(0), Normalize(8)), new Point3D(Normalize(13), Normalize(0), Normalize(11)));
                DrawLine(new Point3D(Normalize(13), Normalize(0), Normalize(11)), new Point3D(Normalize(10), Normalize(0), Normalize(11)));
                DrawLine(new Point3D(Normalize(10), Normalize(0), Normalize(11)), new Point3D(Normalize(8), Normalize(0), Normalize(13)));
                DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(13)), new Point3D(Normalize(8), Normalize(0), Normalize(11)));
                DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(11)), new Point3D(Normalize(3), Normalize(0), Normalize(11)));
                DrawLine(new Point3D(Normalize(3), Normalize(0), Normalize(11)), new Point3D(Normalize(5), Normalize(0), Normalize(8)));
                DrawLine(new Point3D(Normalize(5), Normalize(0), Normalize(8)), new Point3D(Normalize(3), Normalize(0), Normalize(5)));
                DrawLine(new Point3D(Normalize(3), Normalize(0), Normalize(5)), new Point3D(Normalize(8), Normalize(0), Normalize(5)));
                DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(5)), new Point3D(Normalize(8), Normalize(0), Normalize(3)));

            //sides
            DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(3)), new Point3D(Normalize(8), Normalize(4), Normalize(3)));
            DrawLine(new Point3D(Normalize(10), Normalize(0), Normalize(5)), new Point3D(Normalize(10), Normalize(4), Normalize(5)));
            DrawLine(new Point3D(Normalize(13), Normalize(0), Normalize(5)), new Point3D(Normalize(13), Normalize(4), Normalize(5)));
            DrawLine(new Point3D(Normalize(12), Normalize(0), Normalize(8)), new Point3D(Normalize(12), Normalize(4), Normalize(8)));
            DrawLine(new Point3D(Normalize(13), Normalize(0), Normalize(11)), new Point3D(Normalize(13), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(10), Normalize(0), Normalize(11)), new Point3D(Normalize(10), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(13)), new Point3D(Normalize(8), Normalize(4), Normalize(13)));
            DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(11)), new Point3D(Normalize(8), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(3), Normalize(0), Normalize(11)), new Point3D(Normalize(3), Normalize(4), Normalize(11)));
            DrawLine(new Point3D(Normalize(5), Normalize(0), Normalize(8)), new Point3D(Normalize(5), Normalize(4), Normalize(8)));
            DrawLine(new Point3D(Normalize(3), Normalize(0), Normalize(5)), new Point3D(Normalize(3), Normalize(4), Normalize(5)));
            DrawLine(new Point3D(Normalize(8), Normalize(0), Normalize(5)), new Point3D(Normalize(8), Normalize(4), Normalize(5)));

        }

        private void DrawLine(Point3D p1, Point3D p2)
        {
            Line3D line = new Line3D(p1, p2);
            line.Draw(g, alpha, beta, center);
            lines.Add(line);
        }

        private void ApplyTransform()
        {
            InitBitmap();
            DrawAxis();

            List<Line3D> oldLines = new List<Line3D>(lines);
            lines = new List<Line3D>();
            foreach (var line in oldLines)
            {
                DrawLine(line.Start, line.End);
            }
            pictureBox1.Image = bm;
        }

        private double ToRadians(double degrees)
        {
            return Math.PI * degrees / 180.0;
        }

        private int Normalize(int i)
        {
            return i * unit;
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            lines = new List<Line3D>();
            alpha = ToRadians(Convert.ToDouble(txtAngle1.Text));
            beta = ToRadians(Convert.ToDouble(txtAngle2.Text));

            InitBitmap();
            DrawAxis();
            DrawHouse();
            pictureBox1.Image = bm;
        }

   

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtAngle1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}