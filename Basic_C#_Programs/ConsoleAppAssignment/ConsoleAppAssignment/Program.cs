using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bigg", "badd", "strong", "fast" };
            Console.WriteLine("Write an suffix. ex. -er -est -ly -ing -ed");
            string input = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace(words[i], words[i] + input);
                Console.WriteLine(words[i]);
            }
            Console.ReadLine();

            bool trueorFalse = true;
            while (trueorFalse)
            {
                Console.WriteLine("boop");
                trueorFalse = false;
            }
            for (int i = 0; i<  words.Length; i++)
            {
                Console.WriteLine(words.Length);
            }
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(words[i]);
            }

            List<string> iceCreamFlavors = new List<string>() { "vanilla", "chocolate", "pistacio", "strawberry", "peanut" };
            Console.WriteLine("Write your favorite ice cream Flavor");
            string flavorGuess = Console.ReadLine();
            flavorGuess = flavorGuess.ToLower();
            int index = iceCreamFlavors.IndexOf(flavorGuess);
            
                foreach (string flavor in iceCreamFlavors)
                  {
                    if(flavor == flavorGuess)
                {
                    Console.WriteLine("That flavor is at index " + index);
                }
                    else if (flavorGuess!= flavor && index!=4)
                {
                    Console.WriteLine("That flavor is not in the list");
                    break;
                    
                    
                }
                  }
            Console.ReadLine();
        }
    }
}
