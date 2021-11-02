using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int total = 5 + 10;
            //    int otherTotal = 12 + 22;
            //    int combined = total + otherTotal;
            //    Console.WriteLine(combined);
            //    Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotent = 200/ 3;
            //Console.WriteLine(quotent);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueorfalse = 12 < 5;
            //Console.WriteLine(trueorfalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool iswarm = currentTemperature == roomTemperature;
            //Console.WriteLine(iswarm);
            //Console.ReadLine();

            Console.WriteLine("Write a number");
            string inputstr = Console.ReadLine();
            int input = Convert.ToInt32(inputstr);
            long product = input * 50;
            Console.WriteLine(product);
            Console.WriteLine("Write another number");
            string inputstr2 = Console.ReadLine();
            int input2 = Convert.ToInt32(inputstr2);
            int sum = input2 + 25;
            Console.WriteLine(sum);
            Console.WriteLine("Write another number");
            string inputstr3 = Console.ReadLine();
            int input3 = Convert.ToInt32(inputstr3);
            float quotient = input3 / 12.5f;
            Console.WriteLine(quotient);
            Console.WriteLine("Write another number");
            string inputstr4 = Console.ReadLine();
            int input4 = Convert.ToInt32(inputstr4);
            bool over50 = input4 > 50;
            Console.WriteLine(over50);
            Console.WriteLine("Write another number");
            string inputstr5 = Console.ReadLine();
            int input5 = Convert.ToInt32(inputstr5);
            int remainder = input5 % 7;
            Console.WriteLine("The remainder is " +remainder);


            Console.ReadLine();




        }
    }
}
