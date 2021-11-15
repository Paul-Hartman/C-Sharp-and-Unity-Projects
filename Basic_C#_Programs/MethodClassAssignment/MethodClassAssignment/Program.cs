using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            math go = new math();

            go.doMath(3, 6);
            int a = 5;
            int b = 8;
            go.doMath(a, b);
            
            Console.ReadLine();

        }
    }
}
