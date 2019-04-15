using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace Laba3
{
    class Arc : Shape
    {
        private PointF center;
        private float radius;
        private int angleStart;
        private int angleEnd;

        protected override void Execute()
        {
            List<PointF> ps = new List<PointF>();
            for (float i = angleStart; i <= angleEnd + 0.01; i += (angleEnd - angleStart) / radius)
            {
                ps.Add(new PointF(center.X + (float)(radius * Math.Cos(i * Math.PI / 180)), (center.Y + (float)(radius * Math.Sin(i * Math.PI / 180)))));
            }
            Points = ps.ToArray();
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawLines(pen, Points);
        }
    }
}
