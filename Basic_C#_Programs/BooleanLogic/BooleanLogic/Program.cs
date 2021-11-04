using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //and operator
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //or operator
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);


            //Equal operator
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //not equal operator
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != true);
            //Console.WriteLine(false != false);

            //exclusive or operator
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(false ^ true);
            //Console.WriteLine(false ^ false);

            int num1 = 17;
            int num2 = 156;
            int num3 = 20;
            if (num1 > num2 || num3< num2)
            {
                Console.WriteLine("yaaas");
            }
            else if (num1 <= num2)
            {
                Console.WriteLine("nooo");
            }

            string result = num1 > num3 ? "num 1 is greater" : "num 3 is greater";
            Console.WriteLine(result);

            

            Console.ReadLine();
        }
    }
}
