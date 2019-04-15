using System;
using System.Drawing;

namespace lab_5
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        private double[] MultiplyRowByMatrix(double[] row, double[,] matrix)
        {
            double[] result = new double[row.Length];
            for (int i = 0; i < row.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += row[j] * matrix[j, i];
                }
                result[i] = sum;
            }
            return result;
        }

        public Point Projection(double alpha, double beta, Point center)
        {
            double[] result = MultiplyRowByMatrix(
                new[] { X, Y, Z, 1 },
                new[,] {
                    {Math.Cos(beta),  Math.Sin(beta) * Math.Sin(alpha), 0, 0},
                    {             0,                   Math.Cos(alpha), 0, 0},
                    {Math.Sin(beta), -Math.Sin(alpha) * Math.Cos(beta), 0, 0},
                    {             0,                                 0, 0, 1}
                /*    {0,  Math.Cos(alpha)* Math.Sin(beta), -Math.Sin(alpha), 0},
                    {             0,                   Math.Cos(beta), 0, 0},
                    {0, Math.Sin(alpha) * Math.Sin(beta), Math.Cos(alpha), 0},
                    {             0,                                 0, 0, 1} */
                }

            );
            return new Point(center.X + (int)result[0], center.Y + (int)result[1]);
        }
    }
}