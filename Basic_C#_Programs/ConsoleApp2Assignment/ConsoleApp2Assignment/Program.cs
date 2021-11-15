using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 5, 20, 45, 6 };
           
            Console.WriteLine("Enter a number");
            
          try
            {
                int enteredNum = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int newNum = number / enteredNum;
                    Console.WriteLine(newNum);

                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please dont divide by 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter whole numbers");
            }
            Console.ReadLine();
        }
    }
}
