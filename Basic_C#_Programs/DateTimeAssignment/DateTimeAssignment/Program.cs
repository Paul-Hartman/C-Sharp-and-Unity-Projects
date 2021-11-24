using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {Console.WriteLine(DateTime.Now.ToString());
         Console.WriteLine("How far forward would you like to go in the time machine? Enter a number.");
         int add = Convert.ToInt32(Console.ReadLine());
         DateTime now = new DateTime();
         now = DateTime.Now;
         DateTime now1 = now.AddHours(add);
         Console.WriteLine(now1.ToString());

         Console.ReadLine();
        }
    }
}
