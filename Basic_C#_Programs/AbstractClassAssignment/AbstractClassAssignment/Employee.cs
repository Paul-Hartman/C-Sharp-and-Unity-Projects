using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee :Person
    {
        public override void SayName()
        {
            Console.WriteLine("The First employees name is: \n");
            base.SayName();
        }
    }
}
