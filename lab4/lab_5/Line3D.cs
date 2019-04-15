using System.Drawing;

namespace lab_5
{
    public class Line3D
    {
        private static Pen pen = new Pen(Color.Black, 2);

        public Point3D Start { get; set; }
        public Point3D End { get; set; }

        public Point3D[] Points { get { return new[] { Start, End }; } }

        public Line3D(Point3D start, Point3D end)
        {
            Start = start;
            End = end;
        }

        public void Draw(Graphics g, double alpha, double beta, Point center)
        {
            g.DrawLine(pen, Start.Projection(alpha, beta, center), End.Projection(alpha, beta, center));
        }
    }
}