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
            int newNum = Operations.Square(enteredNumber);
            newNum = Operations.AddSub(newNum);
            int OddorEven = Operations.IsOdd(newNum);
            Console.Write(OddorEven);
            Console.ReadLine();
        }
    }
}
