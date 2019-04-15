using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace WpfApp1
{
    class Arc
    {
        Outline Line;
        public Arc(Canvas Canvas)
        {
            Line = new Outline(Canvas);
        }
        public void draw(double xCenter, double yCenter, double Radius, double startAngle, double endAngle, string Tag)
        {
            double
                xStart = xCenter + Radius * Math.Cos(Draw.DegToRad(startAngle)),
                yStart = yCenter + Radius * Math.Sin(-Draw.DegToRad(startAngle));
            bool changeAngle = true;

            while (changeAngle)
            {
                if (startAngle < endAngle)
                {
                    for (double i = startAngle; i <= endAngle; i++)
                    {
                        Calculate(xCenter, yCenter, ref xStart, ref yStart, Radius, i);
                    }
                    changeAngle = false;
                }
                else
                {
                    for (double i = startAngle; i >= endAngle && i <= 360; i++)
                    {
                        Calculate(xCenter, yCenter, ref xStart, ref yStart, Radius, i);
                    }
                    startAngle = 0;
                }
            }
        }
        private void Calculate(double xCenter, double yCenter, ref double xStart, ref double yStart, double Radius, double i)
        {
            double
            x = xCenter + Radius * Math.Cos(Draw.DegToRad(i)),
            y = yCenter + Radius * Math.Sin(-Draw.DegToRad(i));

            Line.Draw(xStart, yStart, x, y, 3, "Black", "Drawing");

            xStart = x;
            yStart = y;
        }
    }
}
