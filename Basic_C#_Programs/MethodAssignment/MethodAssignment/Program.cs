using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.Write("Enter a whole number\n");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number(optional)\n");
            string widthstr = Console.ReadLine();

            Area a = new Area();


            int square = a.area(length);
            Console.WriteLine("the area of your shape is " +square);

            if (widthstr != "")
                {
                int width = Convert.ToInt32(widthstr);

                int rect = a.area(length, width);
                Console.WriteLine("The area of your shape is " + rect);
                 }
            else
            {
                Console.WriteLine("Your shape is a square");
            }

            Console.ReadLine();


        }
    }
}
