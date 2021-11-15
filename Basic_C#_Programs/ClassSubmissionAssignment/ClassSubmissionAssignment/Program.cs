using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 14;
            
            Methods div = new Methods();
            div.Divide(a);

            div.OutArgExample(a, out int number);

            div.OutArgExample(a, b, out int answer);

            int output=Static.Output(b);
            Console.WriteLine(answer);
            Console.WriteLine(number);
            Console.WriteLine(output);
            Console.ReadLine();



        }

        
    }
}
