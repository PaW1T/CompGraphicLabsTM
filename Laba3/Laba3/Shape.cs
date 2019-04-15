using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Laba3
{
    abstract class Shape
    {
        public PointF[] Points { set; get; }
        protected Pen pen;
        public float rotateDegree;
        public abstract void Draw(Graphics gr);
        protected abstract void Execute();
    }
}
