using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba3
{
    class Circle : Shape
    {
        public PointF Center { get; set; }
        private float radius;

        public Circle(PointF center, float radius)
        {
            this.radius = radius;
            Center = center;
            pen = new Pen(Color.Black);
            rotateDegree = 0;
            Execute();
        }

        protected override void Execute()
        {
            List<PointF> ps = new List<PointF>();
            for (float i = 0; i <= 360; i += 360 / radius)
            {
                ps.Add(new PointF(Center.X + (float)(radius * Math.Cos(i * Math.PI / 180)), (Center.Y + (float)(radius * Math.Sin(i * Math.PI / 180)))));
            }
            Points = ps.ToArray();
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawLines(pen, Points);
        }
    }
}
