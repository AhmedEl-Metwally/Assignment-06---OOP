using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    public class Maths
    {
        public static double Add(double a , double c) => a + c;
        public static double Subtract(double a , double c) => a - c;
        public static double Multiply(double a , double c) => a * c;
        public static double Divide(double a , double c) => c !=0 ? a / c : double.NaN;
    }
}
