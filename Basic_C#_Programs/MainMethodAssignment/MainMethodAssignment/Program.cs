using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            
            
            int diff1 = Methods.Subtract(input);
            
            Console.WriteLine(diff1);
            
            float x = 6.6f;
            float y = 4.4f;
            int diff2 = Convert.ToInt32(Methods.Subtract(x, y));
            Console.WriteLine(diff2);

            string a = "24";
            string b = "14";
            string c = "3";
            int diff3 = Methods.Subtract(a, b, c);
            Console.WriteLine(diff3);
            Console.ReadLine();
        }
    }
}
