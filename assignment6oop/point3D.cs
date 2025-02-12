using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6oop
{
    internal class Point3D : ICloneable, IComparable<Point3D>
    {
       
        public int X { get; set; }
        public int Y { get; set; }

        public int Z { get; set; }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;

        }

        public Point3D(int value) : this()
        {
            X = Y = Z = value;
        }

        public Point3D(int x, int y, int z) : this() { X = x; Y = y; Z = z; }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D otherPoint3D)
            {
                return this.X == otherPoint3D.X &&
                       this.Y == otherPoint3D.Y &&
                       this.Z == otherPoint3D.Z;
            }
            return false;
        }

        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }

        public int CompareTo(Point3D other)
        {
            if (other == null)
                return 1;


            int xComparison = X.CompareTo(other.X);
            if (xComparison != 0)
                return xComparison;


            return Y.CompareTo(other.Y);
        }
        
    }
}
