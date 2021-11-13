using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "dog", "cat", "fish", "bird" };
            int[] intArray = { 2, 4, 6, 8 };
            Console.WriteLine("Pick a number between 0 and 3");
            int input = Convert.ToInt32(Console.ReadLine());
            
            if (input>3)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
                Console.WriteLine("The string at that that index is " + stringArray[input]);
            }
            Console.WriteLine("Pick another number between 0 and 3");
            int intInput = Convert.ToInt32(Console.ReadLine());
            if (intInput > 3)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
                Console.WriteLine("The integer at that index in the array is " + intArray[intInput]);
            }
            List<string> stringList = new List<string>();
            stringList.Add("tschuss");
            stringList.Add("goodbye");
            stringList.Add("ciao");
            stringList.Add("adios");
            Console.WriteLine("Pick a number between 0 and 3");
            int listInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The string at that index of the list is " + stringList[listInput]);

            Console.Read();
            
        }
    }
}
