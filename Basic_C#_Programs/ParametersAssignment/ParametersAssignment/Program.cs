using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee<string> A = new Employee<string>();
            A.Things = new List<string>() { "Pen", "Pencil", "Marker", "Crayon"};
            

            Employee<int> B = new Employee<int>();
            B.Things = new List<int>() { 1, 4, 12, 67 };
            Console.WriteLine("Employee A's things: ");
            foreach (string thing in A.Things)
            {
                Console.WriteLine(thing);
                
            }

            Console.WriteLine("\nEmployee B's things: ");
            foreach (int thing in B.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
