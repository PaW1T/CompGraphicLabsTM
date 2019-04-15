using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;


namespace Laba3
{
    class StringShape : Shape
    {
        private string text;
        private Brush brush;
        private float x, y;
        private Font f;

        protected override void Execute()
        {
            List<PointF> lp = new List<PointF>();
            lp.Add(new PointF(x, y));
            Points = lp.ToArray();
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawString(text, f, brush, Points[0]);
        }
    }
}
