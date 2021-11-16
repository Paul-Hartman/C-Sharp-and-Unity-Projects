using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.firstName = "Sample ";
            Emp1.lastName = "Student";
            Emp1.SayName();

            
            IQuittable Emp2 = new Employee();

            Emp2.Quit();

            Employee a = new Employee();
            Employee b = new Employee();
            a.Id = 01;
            b.Id = 01;

            _ = a != b;
            _ = a == b;
            Console.WriteLine(b.Id);
            Console.ReadLine();

        }
    }
}
