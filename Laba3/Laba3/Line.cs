using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba3 
{
    class Line : Shape
    {
        private PointF start;
        private PointF end;

        public Line(Pen p, PointF start, PointF end)
        {
            this.start = start;
            this.end = end;
            pen = p;
            rotateDegree = 0;
            Execute();
        }

        protected override void Execute()
        {
            Points = new PointF[2] { new PointF(this.start.X, this.start.Y), new PointF(this.end.X, this.end.Y) };
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawLines(pen, Points);
        }
    }
}
