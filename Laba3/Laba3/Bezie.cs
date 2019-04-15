using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba3
{
    class Bezie
    {
        private Line ln1;
        private Line ln2;
        private Line ln3;
        private Line ln4;
        private Line ln5;
        private Pen pen;
        public List<PointF> Points { get; set; }

        public int Index { get; set; }

        public Bezie(PointF[] p, int index)
        {
            pen = new Pen(Color.Black)
            {
                Width = 3f
            };
            Index = index;
            Points = p.ToList();
        }
        public Bezie(string p, int index)
        {
            pen = new Pen(Color.Black)
            {
                Width = 3f
            };
            Index = index;
            string[] s = p.Split(';');
            Points = new List<PointF>();
            for (var i = 0; i < 6; i++)
            {
                Points.Add(new PointF(Convert.ToSingle(s[i].Split(',')[0]), Convert.ToSingle(s[i].Split(',')[1])));
            }
        }

        public void Draw(Graphics gr, bool showControls)
        {
            Pen p = new Pen(Color.Purple);

            ln1 = new Line(p, Points[0], Points[1]);
            ln2 = new Line(p, Points[1], Points[2]);
            ln3 = new Line(p, Points[2], Points[3]);
            ln4 = new Line(p, Points[3], Points[4]);
            ln5 = new Line(p, Points[4], Points[5]);
            if (showControls)
            {
                ln1.Draw(gr);
                ln2.Draw(gr);
                ln3.Draw(gr);
                ln4.Draw(gr);
                ln5.Draw(gr);
                foreach (var item in Points)
                {
                    new Circle(item, 4).Draw(gr);
                }
            }
            List<PointF> pf = new List<PointF>();
            for (float t = 0; t <= 1 + 0.01; t += 0.05f)
            {
               
                float x = Convert.ToSingle(Points[0].X * Math.Pow(1 - t, 5) + 5 * Points[1].X * Math.Pow(1 - t, 4) * t + 10 * Points[2].X * Math.Pow(t, 2) * Math.Pow(1 - t, 3) + 10 * Points[3].X * Math.Pow(t, 3) * Math.Pow(1 - t, 2) + 5 * Points[4].X * Math.Pow(t, 4) * (1 - t) + Points[5].X * Math.Pow(t, 5));
                float y = Convert.ToSingle(Points[0].Y * Math.Pow(1 - t, 5) + 5 * Points[1].Y * Math.Pow(1 - t, 4) * t + 10 * Points[2].Y * Math.Pow(t, 2) * Math.Pow(1 - t, 3) + 10 * Points[3].Y * Math.Pow(t, 3) * Math.Pow(1 - t, 2) + 5 * Points[4].Y * Math.Pow(t, 4) * (1 - t) + Points[5].Y * Math.Pow(t, 5));

                pf.Add(new PointF(x, y));
            }
            gr.DrawLines(pen, pf.ToArray());
        }
    }
}
