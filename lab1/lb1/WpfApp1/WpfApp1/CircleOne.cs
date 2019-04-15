using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class CircleOne
    {
        private Arc Arc;
         public CircleOne(Canvas Canvas)
         {
             Arc = new Arc(Canvas);
         }
        public void Draw(double xCenter, double yCenter, double Radius, string Tag)
        {
            Arc.draw(xCenter, yCenter, Radius, 0, 360, "Drawing");
        }
    }
}
