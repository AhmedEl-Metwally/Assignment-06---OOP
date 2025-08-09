using FirstProject.Models;
using FirstProject.Services;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project:
            //1.Define 3D Point Class and the basic Constructors(use chaining in constructors).
            //2.Override the ToString Function to produce this output:
            // Point3D P = new Point3D(10, 10, 10);
            // Console.WriteLine(P.ToString());
            // Output: “Point Coordinates: (10, 10, 10)”.
            //3.Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).
            //4.Try to use  ==
            //If(P1 == P2)  Does it work properly? 
            //5.Define an array of points and sort this array based on X &Y coordinates.
            //6.Implement ICloneable interface to be able to clone the object.

            Console.WriteLine("Enter point: ");
            int count = int.Parse(Console.ReadLine() ?? "0");

            Point3D[] points = new Point3D[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter for point{i+1}: ");
                points[i] = Point3DService.ReadPoint();
            }

            Console.WriteLine("Enter all point: ");
            Point3DService.PrintPoint(points);

            Array.Sort(points);
            Console.WriteLine("Sort points");
            Point3DService.PrintPoint(points);

            if(points.Length >= 2)
            Console.WriteLine(points[0] == points[1] ? "First two points are equal" : "First two points are NOT equal");

            if(points.Length >0)
             {
                Point3D clonedPoint = (Point3D)points[0].Clone();
                Console.WriteLine($"Cloned Point: {clonedPoint}");
            }

            #endregion
        }
    }
}
