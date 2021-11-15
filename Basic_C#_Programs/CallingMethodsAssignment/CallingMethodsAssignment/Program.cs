using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            Operations math = new Operations();

            int square = math.Square(enteredNumber);
            Console.WriteLine("Your number squared " +square);

            int OddOrEven = math.IsOdd(enteredNumber);
            Console.WriteLine("Is it Odd " +OddOrEven);

            int sum = math.AddSub(enteredNumber);
            Console.WriteLine("Your number increased or reduced "+sum);
            Console.Read();
       
        }
    }
}
