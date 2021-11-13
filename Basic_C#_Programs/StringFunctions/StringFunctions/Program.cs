using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Paul";
            //string quote = "The man said, \"Hello\". \n Hello on a new line. \n \t Hello on a tab \n";
            //string fileName1 = "C:\\Users\\Paul \n C:\\\\Users\\\\Paul";
            //string fileName2 = @"C:\Users\Paul";

            //bool trueOrFalse = name.Contains("a");
            //trueOrFalse = name.EndsWith("b");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();
            //Console.WriteLine(quote + fileName1 +trueOrFalse + length +name);
            //Console.Read();

            //string name = "gnome";
            //name = "nome";

            //StringBuilder sb = new StringBuilder();
            //sb.Append("my name is paul");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            //Strings Challenge
            string greeting = "Guten tag";
            string name = " Herr Muller. ";
            string question = "Wie kann ich dir hilfen?";
            Console.WriteLine(greeting + name + question);
            Console.ReadLine();

            name = name.ToUpper();
            StringBuilder sb = new StringBuilder();
            sb.Append("\n this is the first line\n"+ greeting);
            sb.Append("\n this is the second line\n" + name);
            sb.Append("\n this is the third line\n" + question);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
