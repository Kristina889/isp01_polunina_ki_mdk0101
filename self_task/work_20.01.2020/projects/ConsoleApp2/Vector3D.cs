using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public double ScalarProduct(Vector3D other)
        {
            return (X * other.X + Y * other.Y + Z * other.Z);
        }
        public Vector3D Composition(Vector3D other)
        {
            return new Vector3D(Y * other.Z - Z * other.X, Z
                                 * other.X - X * other.Z, X * other.Y - Y * other.X);
        }
        public override string ToString()
        {
            return $"Vector3D: ({X}, {Y}, {Z})";
        }
    }
}
