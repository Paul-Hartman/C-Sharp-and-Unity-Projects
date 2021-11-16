using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("The First employees name is: \n");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("The program was Quit");
            Console.ReadLine();
        }

        public static Employee operator== (Employee a, Employee b)
        {

            bool SameId = a.Id == b.Id;
            if (SameId == true)
            {
                Console.WriteLine("These Employees have the same ID");
                b.Id++;
            }
            else
            {
                Console.WriteLine("These Employees do not have the same ID");
            }
            Console.ReadLine();
            return b;

        }
        public static Employee operator!= (Employee a, Employee b)
        {
            bool SameId = a.Id != b.Id;
            if (SameId==true)
            {
                Console.WriteLine("These Employees do not have the same ID") ;
            }
            else
            {
                Console.WriteLine("These Employees have the same ID");
                b.Id++;
            }
            Console.ReadLine();
            return b;
        }

    }
}
