using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperature = 69;
            int roomTemperature = 70;
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("it is colder than room temperature");
            //}

            //string comparisonresults = currentTemperature == roomTemperature ? "it is room temperature" : "it is not room temp";
            //Console.WriteLine(comparisonresults);

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temerature where you are");
            //int currenttermperature = Convert.ToInt32(Console.ReadLine());

            //if (currenttermperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currenttermperature>roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temperature");
            //}
            //else if (currenttermperature<roomTemperature)
            //{
            //    Console.WriteLine("it is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("im an extra optiuon that will never be picked");
            //}
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());
            //string results = favNum == 7 ? "you have a good favorite number" : "you do not have anawesome favorite number";
            //Console.WriteLine(results);
            //Console.ReadLine();

            int day = 1;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                
            }
            Console.Read();
        }
    }
}
