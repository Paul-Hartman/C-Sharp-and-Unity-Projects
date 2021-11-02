using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 \nWhat is your Hourly Rate?");
            string p1HourlyRate = Console.ReadLine();
            int p1rate = Convert.ToInt32(p1HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string p1HoursperWeek = Console.ReadLine();
            int p1week = Convert.ToInt32(p1HoursperWeek);

            Console.WriteLine("Person 2 \nWhat is your Hourly Rate?");
            string p2HourlyRate = Console.ReadLine();
            int p2rate = Convert.ToInt32(p2HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string p2HoursperWeek = Console.ReadLine();
            int p2week = Convert.ToInt32(p2HoursperWeek);
            int p1AnnualSalary = p1rate * p1week * 52;
            int p2AnnualSalary = p2rate * p2week * 52;
            bool richer = p1AnnualSalary > p2AnnualSalary;

            Console.WriteLine("Annual salary Person1: \n$" + p1AnnualSalary);
            Console.WriteLine("Annual salary Person2: \n$" + p2AnnualSalary);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n"+ richer);

           

            Console.ReadLine();
        }
    }
}
