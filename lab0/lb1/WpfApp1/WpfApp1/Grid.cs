using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1;

namespace WpfApp1
{
    class Grid
    {
        private Outline line;
        private double width;
        private double height;
        private double unit;
        private int count;
        public int Count => count;

        public Grid(Canvas canvas, double width, double height, double unit)
        {
            line = new Outline(canvas);
            this.width = width;
            this.height = height;
            this.unit = unit;
        }
        
        /*public void Ddraw()
        {
            drawAxis();
            drawGrid();
        }*/

        public void drawAxis()
        {
            line.Draw(0, height - 195 * height / 439, width, height - 195 * height / 439, 4, "Black", "xAxis"); count++; //AxisY
            line.Draw(0, height, 0, 0, 4, "Black", "yAxis"); count++;
            //line.Draw(0, height, width, height, 1, "Black", "xAxis"); count++;
            //line.Draw(width, height, width, 0, 1, "Black", "yAxis"); count++;
        }
        public void drawGrid()
        {
            for (double i = height; i >= unit; i -= unit)
            {
                line.Draw(0, i, width, i, .5, "Black", "Grid");
                count++;
            }
            for (double i = unit; i < width; i += unit)
            {
                line.Draw(i, height, i, 0, .5, "Black", "Grid");
                count++;
            }
        }
        public void clearGrid()
        {
            line.Draw(0, 0, width, height, (width * 2), "White", "Clear");
        }
        public void clearAxis()
        {
            line.Draw(0, 0, width, height, (width * 2), "White", "Clear");
        }
        public void clearSizes()
        {
            line.Draw(0, 0, width, height, (width * 2), "White", "Clear");
        }

        public void clearHelpes()
        {
            line.Draw(0, 0, width, height, (width * 2), "White", "Clear");
        }
    }
}