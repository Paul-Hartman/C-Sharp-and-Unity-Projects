using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("counting");
            int number = 1;
            
            while(number <=10)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine("guess my age you have 3 tries");
            int guess = Convert.ToInt32(Console.ReadLine());
            int tries = 3;
            bool age = guess == 23;

            do
            {
                switch (guess)
                {
                    case int n when (n<23):
                        Console.WriteLine("Too young. try again");
                        Console.WriteLine("you have "+ tries +" more guesses");
                        tries--;
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case int n when (n > 23):
                        Console.WriteLine("Too old. try again. Try again");
                        Console.WriteLine("you have " + tries + " more guesses");
                        tries --;
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 23:
                        Console.WriteLine("That is correct");
                        age = true;
                        break;
                    default:
                        Console.WriteLine("you are wrong");
                        Console.WriteLine("you have " + tries + " more guesses");
                        tries--;
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!age && tries>0);



            Console.Read();
        }
    }
}
