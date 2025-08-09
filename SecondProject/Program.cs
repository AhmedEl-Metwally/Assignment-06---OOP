using SecondProject.Models;

namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Second Project:
                    //Define Class Maths that has four methods:
                    //●Add()
                    //●Subtract()
                    //●Multiply()
                    //●Divide()
                    //Each of them takes two parameters. Call each method in Main().
                    //NOTE : Modify the program so that you do not have to create an instance of class to call the four methods.


            double num1 = ReadDouble("Enter first number: ");
            double num2 = ReadDouble("Enter second number: ");

            Console.WriteLine($"Add: {Maths.Add(num1, num2)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(num1, num2)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(num1, num2)}");

            if(num2!= 0)        
                Console.WriteLine($"Divide: {Maths.Divide(num1, num2)}");
            else
                Console.WriteLine("Cannot divide by zero.");
         

            static double ReadDouble(string message)
            {
                Console.WriteLine(message);
                if(double.TryParse(Console.ReadLine(), out double value))
                    return value;
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return ReadDouble(message);
                }



            }



            #endregion;
        }
    }
}
