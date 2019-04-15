using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    class Draw
    {
        private Canvas canvas;
        public Grid grid;
        private Transform transform;
        private double width = 0;
        private double height = 0;
        private double unit = 0;
        public Draw(Canvas canvas, double unit)
        {
            this.canvas = canvas;
            this.unit = unit;
        }

        public void PerformEuclid(double ShiftX, double ShiftY, double PointX, double PointY, double Angle)
        {
            transform.PerformEuclid(ShiftX, ShiftY, PointX, PointY, Angle);
        }
        public void PerformAffine(double x0, double y0, double x1, double y1, double x2, double y2)
        {
            transform.PerformAffine(x0, y0, x1, y1, x2, y2);
        }
        public void PerformProjective(double pX0, double pY0, double pW0, double pXx, double pXy, double pWx, double pYx, double pYy, double pWy)
        {
            transform.PerformProjective(pX0, pY0, pW0, pXx, pXy, pWx, pYx, pYy, pWy);
        }

        public void SetText()
        {
            width = canvas.ActualWidth;
            height = canvas.ActualHeight;
            double unit = 10;
            Outline OutLn = new Outline(canvas);
            transform = new Transform(canvas, height, unit);


            OutLn.SetText((width / 2) - 20, (height / 2) + 3, "0;0", "Regular", "Black", "CoordCentr");
            OutLn.SetText(width - 30, height - 25, "x", "Bold", "Black", "AxisX");
            OutLn.SetText(10, 0, "y", "Bold", "Black", "AxisY");
            OutLn.SetText((width / 2) + unit, (height / 2) + 3, "1", "Regular", "Black", "VectX");
            OutLn.SetText((width / 2) + 10, (height / 2) - unit - 10, "1", "Regular", "Black", "VectY");

        }


        public void SetSizes(double r1, double r2, double H, double r3)
        {
            width = canvas.ActualWidth;
            height = canvas.ActualHeight;
            Outline OutLn = new Outline(canvas);
            transform = new Transform(canvas, height, unit);
            double XCenter = width / 2, YCenter = height / 2;

            OutLn.SetSizes(XCenter - H / 2, YCenter, XCenter - H / 2, YCenter - r1, 1, XCenter - H / 2 + 5, YCenter - r1 / 1.5, "r1", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter - H / 2, YCenter - r1, XCenter - H / 2 - 5, YCenter - r1 + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter - H / 2, YCenter - r1, XCenter - H / 2 + 5, YCenter - r1 + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter - H / 2, YCenter, XCenter - H / 2 - 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter - H / 2, YCenter, XCenter - H / 2 + 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");

            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H + r2, YCenter, 1, XCenter + H + r2 / 2, YCenter + 3, "r2", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H + r2, YCenter, XCenter + H + r2 - 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H + r2, YCenter, XCenter + H + r2 - 5, YCenter + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H + 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H + 5, YCenter + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");

            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H, YCenter - r3, 1, XCenter + H + 5, YCenter - 30, "r3", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H + 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H - 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter - r3, XCenter + H + 5, YCenter - r3 + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter - r3, XCenter + H - 5, YCenter - r3 + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");



            OutLn.SetSizes(XCenter, YCenter, XCenter + H, YCenter, 1, XCenter + 40, YCenter + 2, "H", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter, YCenter, XCenter + 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter, YCenter, XCenter + 5, YCenter + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H - 5, YCenter - 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
            OutLn.SetSizes(XCenter + H, YCenter, XCenter + H - 5, YCenter + 5, 1, XCenter, YCenter, "", "Regular", "Red", "Drawing");
        }

        public void HelpLines(double r1, double r2, double H, double r3)
        {
            width = canvas.ActualWidth;
            height = canvas.ActualHeight;
            Outline OutLn = new Outline(canvas);
           
            double XCenter = width / 2, YCenter = height / 2;

            OutLn.HelpLines(XCenter - H / 2, YCenter - 2 * r1, XCenter - H / 2, YCenter + 2 * r1, 0.3, XCenter, YCenter, "", "Regular", "Blue", "Drawing");
            OutLn.HelpLines(XCenter + H + r1 + r3, YCenter, XCenter + r1 / 2, YCenter, 0.3, XCenter, YCenter, "", "Regular", "Blue", "Drawing");
            OutLn.HelpLines(XCenter + H, YCenter - r3 - r1, XCenter + H, YCenter + r3 + r1, 0.3, XCenter, YCenter, "", "Regular", "Blue", "Drawing");
            OutLn.HelpLines(XCenter - H / 2 - 2 * r1, YCenter, XCenter - H / 2 + 2 * r1, YCenter, 0.3, XCenter, YCenter, "", "Regular", "Blue", "Drawing");

        }

        public void SetDraw(double r1, double r2, double H, double r3)
        {
            canvas.Children.Clear();
            width = canvas.ActualWidth;
            height = canvas.ActualHeight;
            grid = new Grid(canvas, width, height, unit);

            double XCenter = width / 2, YCenter = height / 2;
            if (r1 > r2 || r1 + r2 > H || r3 > H || r1 >= 50 || r3 < 50 || H > 160 || r2 >= 50)
            {
                MessageBox.Show("Введите другие параметры, которые будут соответсвовать следующим правилам: r1 > r2, r1 + r2 > H, r3 > H, r1 < 40, r2 < 80, r3 < 40, H < 160", "Неправильные параметры!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

            
                if (canvas.Children.Count > grid.Count)
                    canvas.Children.RemoveRange(grid.Count, canvas.Children.Count - 1);
                Outline OutLn = new Outline(canvas);
                CircleOne Circle = new CircleOne(canvas);
                Arc Arc = new Arc(canvas);
                transform = new Transform(canvas, height, unit);
                double t = Math.Sqrt(r2 * r2 - r1 * r1);
                //120
                OutLn.Draw(XCenter - H / 2, YCenter + r3, XCenter + H, YCenter + r3, 3, "Black", "Drawing"); //verkh
                OutLn.Draw(XCenter - H / 2, YCenter - r3, XCenter + H, YCenter - r3, 3, "Black", "Drawing");
                //
                OutLn.Draw(XCenter - H / 2, YCenter + r1, XCenter + H - t, YCenter + r1, 3, "Black", "Drawing");
                OutLn.Draw(XCenter - H / 2, YCenter - r1, XCenter + H - t, YCenter - r1, 3, "Black", "Drawing");
                //
                OutLn.Draw(XCenter - H / 2, YCenter + r3, XCenter - H / 2, YCenter + 2 * r3, 3, "Black", "Drawing");
                OutLn.Draw(XCenter - H / 2, YCenter - r3, XCenter - H / 2, YCenter - 2 * r3, 3, "Black", "Drawing");
                //
                OutLn.Draw(XCenter - H / 2 - 2 * r2, YCenter + 2 * r3, XCenter - H / 2, YCenter + 2 * r3, 3, "Black", "Drawing");
                OutLn.Draw(XCenter - H / 2 - 2 * r2, YCenter - 2 * r3, XCenter - H / 2, YCenter - 2 * r3, 3, "Black", "Drawing");
                //
                OutLn.Draw(XCenter - H / 2 - 2 * r2, YCenter - 2 * r3, XCenter - H / 2 - 2 * r2, YCenter + 2 * r3, 3, "Black", "Drawing");
                //////////////////////////////////////////////////////////////
                Arc.draw(XCenter - H / 2, YCenter, r1, 90, 270, "Drawing"); // left
                Arc.draw(XCenter + H, YCenter, r2, 215, 145, "Drawing"); // right
                Arc.draw(XCenter + H, YCenter, r3, 270, 90, "Drawing");

            }
        }


public static double DegToRad(double degree)
        {
            return degree * (Math.PI / 180);
        }
    }
}
