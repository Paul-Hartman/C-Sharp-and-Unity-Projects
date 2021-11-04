using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nHow much does your package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day!");
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
            }
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of your package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of your package?");
            int length = Convert.ToInt32(Console.ReadLine());
            int total = width + height + length;
            int quote = ((width * height * length) * weight) / 100;
            string result = total > 50 ? "This package is too big to be shipped by package express" :
                "Your estimated price for shipping this package is: $" + Convert.ToString(quote) + ".00\nThank You!";
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
