using FirstProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class Point3D : IPoint3D
    {
        public double X { get ; set ; }
        public double Y { get ; set ; }
        public double Z { get ; set ; }

        public Point3D() : this(0,0,0) { }
        public Point3D(double x, double y) : this(x, y, 0) { }
        public Point3D(double x, double y, double z) 
        { 
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() => $"Point Coordinates: ({X}, {Y}, {Z})";

        public static  bool operator == (Point3D p1 , Point3D p2)
        {
            if(ReferenceEquals(p1,p2))
                return true;
            if(p1 is not null || p2 is not null )
                return false;

            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2) => !(p1 ==p2);

        public override bool Equals(object? obj)
        {
            if (obj is Point3D other)
                return this == other;
            return false;
        }

        public override int GetHashCode() => (X,Y ,Z).GetHashCode();

        public object Clone() => new Point3D(X , Y ,Z);


        public int CompareTo(object? obj)
        {
            if(obj is IPoint3D other)
                return CompareTo(other);
            throw new ArgumentException("Object is not a Point3D");

        }

        public int CompareTo(IPoint3D? other)
        {
            int compareX = X.CompareTo(other.X);

            if (compareX == 0)
                return Y.CompareTo(other.Y);
            return compareX;
        }
    }
}
