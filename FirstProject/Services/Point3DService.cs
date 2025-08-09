using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Services
{
    public class Point3DService
    {
        public static Point3D ReadPoint()
        {
            double x = ReadDouble("Enter X: ");
            double y = ReadDouble("Enter Y: ");
            double z = ReadDouble("Enter Z: ");
            return new Point3D(x, y, z);
        }

        private static double ReadDouble(string prompt)
        {
            Console.WriteLine(prompt);

            if(double.TryParse(Console.ReadLine(), out double value))
                return value;

            Console.WriteLine("Invalid input. Please enter a number.");
            return ReadDouble(prompt);
        }

        public static void PrintPoint(Point3D[] points)
        {
            foreach(var point in points)
                Console.WriteLine(point);
        }

    }
}
