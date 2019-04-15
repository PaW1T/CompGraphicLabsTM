using System;
using System.Windows.Shapes;
using System.Windows.Controls;


namespace WpfApp1
{
    class Transform
    {
    
		private Canvas canvas;
        private double height = 0;
        private double unit = 0;

        public Transform(Canvas canvas, double height, double unit)
        {
            this.canvas = canvas;
            this.height = height;
            this.unit = unit;
        }

        public void PerformEuclid(double x, double y, double xPoint,
            double yPoint, double degree)
        {
            Shift(x, y);
            Rotate(xPoint, yPoint, degree);
        }

        private void Shift(double x, double y)
        {
            foreach (Line line in canvas.Children)
            {
                if (line.Tag.ToString() == "Drawing") //attention
                {
                    line.X1 += x * unit;
                    line.Y1 -= y * unit;
                    line.X2 += x * unit;
                    line.Y2 -= y * unit;
                }
            }
        }
        private void Rotate(double x0, double y0, double degree)
        {
            double x1, y1, x2, y2;
            degree = -degree;
            y0 = height - y0;

            foreach (Line line in canvas.Children)
            {
                if (line.Tag.ToString() == "Drawing")
                {
                    x1 = line.X1;
                    y1 = line.Y1;
                    x2 = line.X2;
                    y2 = line.Y2;

                    line.X1 = x0 + (x1 - x0) * Math.Cos(Draw.DegToRad(degree)) - (y1 - y0) * Math.Sin(Draw.DegToRad(degree));
                    line.Y1 = y0 + (x1 - x0) * Math.Sin(Draw.DegToRad(degree)) + (y1 - y0) * Math.Cos(Draw.DegToRad(degree));
                    line.X2 = x0 + (x2 - x0) * Math.Cos(Draw.DegToRad(degree)) - (y2 - y0) * Math.Sin(Draw.DegToRad(degree));
                    line.Y2 = y0 + (x2 - x0) * Math.Sin(Draw.DegToRad(degree)) + (y2 - y0) * Math.Cos(Draw.DegToRad(degree));
                }
            }
        }

        public void PerformAffine(double x0, double y0, double x1, double y1, double x2, double y2)
        {
            double x1prev, y1prev, x2prev, y2prev;
            foreach (Line line in canvas.Children)
            {
                if (line.Tag.ToString() == "xAxis")
                { SetLine(line, x0 * unit * 48, y0 * unit * 48, x1 * unit * 48, y1 * unit * 48); }
                //{ SetLine(line, x0, y0, x1, y1); }
                else if (line.Tag.ToString() == "yAxis")
                {
                    SetLine(line, x0 * unit * 48, y0 * unit * 48, x2 * unit * 48, y2 * unit * 48);
            
                }
                else
                {
                    x1prev = line.X1; y1prev = line.Y1;
                    x2prev = line.X2; y2prev = line.Y2;

                    line.X1 =  (x0 + x1 * x1prev + x2 * y1prev);
                    line.Y1 = height - (y0 + y1 * x1prev + y2 * y1prev);
                    line.X2 =  (x0 + x1 * x2prev + x2 * y2prev);
                    line.Y2 = height - (y0 + y1 * x2prev + y2 * y2prev);
                }
            }
        }

        public void PerformProjective(double pX0, double pY0, double pW0, double pXx, double pXy, double pWx, double pYx, double pYy, double pWy)
        {
            double X1, Y1, X2, Y2;

            pX0 *= unit; pY0 *= unit;
            pXx *= unit; pXy *= unit;
            pYx *= unit; pYy *= unit;

            foreach (Line line in canvas.Children)
            {
                if (line.Tag.ToString() == "xAxis") SetLine(line, pX0, pY0, pXx, pXy);
                else if (line.Tag.ToString() == "yAxis") SetLine(line, pX0, pY0, pYx, pYy);
                else
                {
                    X1 = line.X1;
                    Y1 = line.Y1;
                    X2 = line.X2;
                    Y2 = line.Y2;

                    line.X1 = (pX0 * pW0 + pXx * pWx * X1 + pYx * pWy * Y1) / (pW0 + pWx * X1 + pWy * Y1);
                    line.Y1 = height - ((pY0 * pW0 + pXy * pWx * X1 + pYy * pWy * Y1) / (pW0 + pWx * X1 + pWy * Y1));
                    line.X2 = (pX0 * pW0 + pXx * pWx * X2 + pYx * pWy * Y2) / (pW0 + pWx * X2 + pWy * Y2);
                    line.Y2 = height - ((pY0 * pW0 + pXy * pWx * X2 + pYy * pWy * Y2) / (pW0 + pWx * X2 + pWy * Y2));
                }
            }
        }

        private void SetLine(Line Line, double X1, double Y1, double X2, double Y2)
        {
            Line.X1 = X1;
            Line.Y1 = height - Y1;
            Line.X2 = X2;
            Line.Y2 = height - Y2;
        }
    }
}
