using Microsoft.VisualBasic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Xml.Linq;
using ThirdProject.Models;

namespace ThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Third Project:
            //You are tasked with designing a system for an e-commerce platform that calculates discounts for different types of users and products.
            //This system should utilize abstraction and include the following parts:
            //Part 1: Abstract Discount Class
            // Create an abstract class Discount with:
            //oAn abstract method CalculateDiscount(decimal price, int quantity) that returns the discount amount based on the original price and quantity.
            //oA Name property to store the type of discount.

            //Part 2: Specific Discounts
            //Implement the following concrete discount classes:
            //oPercentageDiscount:
            //▪Accepts a percentage (e.g., 10%).
            //▪Formula: Discount Amount = Price×Quantity×(Percentage/100)
            //oFlatDiscount:
            //▪Accepts a fixed amount to be deducted(e.g., 50).
            //▪Formula: Discount Amount = Flat Amount×min(Quantity, 1)
            //oBuyOneGetOneDiscount:
            //▪Applies a 50 % discount if the quantity is greater than 1.
            //▪Formula: Discount Amount = (Price / 2)×(Quantity÷2)


            //Part 3: Discount Applicability
            //Create an abstract class User with:
            //oA Name property to store the user name.
            //oAn abstract method GetDiscount() that returns a Discount object.
            //Implement the following specific user types:
            //oRegularUser: Applies a PercentageDiscount of 5%.
            //oPremiumUser: Applies a FlatDiscount of 100.
            //oGuestUser: No discount is applied

            //Part 4: Integration
            //Write a program that:
            //oAsk the user to input their type(Regular, Premium, or Guest).
            //oAllows the user to input product details(price and quantity).
            //oCalculates and displays the total discount and final price after applying the appropriate discount.

            Console.WriteLine("Enter your user type (Regular, Premium, Guest): ");
            string userType = Console.ReadLine()?.Trim();

            //User user = userType?.ToLower() switch
            //{
            //    "Regular" => new RegularUser(),
            //    "Premium" => new RegularUser(),
            //    "Guest" => new RegularUser(),
            //    _ => throw new ArgumentException("Invalid user type")
            //};

            User user = userType?.ToLower() switch
            {
                "regular" => new RegularUser(),
                "premium" => new PremiumUser(),
                "guest" => new GuestUser(),
                _ => throw new ArgumentException("Invalid user type")
            };


            Console.WriteLine("Enter your name: ");
            user.Name = Console.ReadLine() ?? string.Empty;

            decimal price = ReadDecimal("Enter the product price: ");
            int quantity = ReadInt("Enter the product quantity: ");

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(price, quantity);
            decimal finalPrice = (price * quantity) - discountAmount;

            Console.WriteLine($"Customer: {user.Name}");
            Console.WriteLine($"Discount: {discount.Name}");
            Console.WriteLine($"Total Discount: {discountAmount:C}");
            Console.WriteLine($"Final Price: {finalPrice:C}");

            #endregion

        }

        private static decimal ReadDecimal(string prompt)
        {
            Console.WriteLine(prompt);
            if(decimal.TryParse(Console.ReadLine(), out decimal value))
               return value;
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                return ReadDecimal(prompt); 
            }
        }

        private static int ReadInt(string prompt)
        {
            Console.WriteLine(prompt);
            if(int.TryParse(Console.ReadLine(), out int value))
                return value;
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return ReadInt(prompt);
            }
        }
    }
}
