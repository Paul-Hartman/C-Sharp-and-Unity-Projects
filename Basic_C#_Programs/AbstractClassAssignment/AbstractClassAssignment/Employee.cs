using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee :Person, IQuittable
    {
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
    }
}
