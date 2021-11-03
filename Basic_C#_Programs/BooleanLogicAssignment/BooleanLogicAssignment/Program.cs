using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval program \nWhat is your age?");
            string driverAge = Console.ReadLine();
            int age = Convert.ToInt32(driverAge);
            Console.WriteLine("Have you had a DUI? True or False");
            string hasDUI  = Console.ReadLine();
            bool dui = Convert.ToBoolean(hasDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketnumber = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketnumber);
            bool isqualified = age > 15 && dui == false && tickets <= 3;
            Console.WriteLine("Qualified? \n" + isqualified);
            Console.ReadLine(); 


        }
    }
}
