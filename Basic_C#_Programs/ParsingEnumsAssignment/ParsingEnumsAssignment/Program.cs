using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {   enum DaysOfTheWeek
        {   
            None,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string value = Console.ReadLine();
            DaysOfTheWeek dayOfWeek;
            try
            {
                dayOfWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
                Console.WriteLine("Today is " + dayOfWeek);

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
                dayOfWeek = DaysOfTheWeek.None;
            }
            Console.ReadLine();
        }
    }
}
