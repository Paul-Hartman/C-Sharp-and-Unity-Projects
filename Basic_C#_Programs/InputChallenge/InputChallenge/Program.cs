using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Paul\Logs\log2.txt",input);
            string text = File.ReadAllText(@"C:\Users\Paul\Logs\log2.txt");
            Console.WriteLine(text);
            Console.ReadLine(); 

        }
    }
}
