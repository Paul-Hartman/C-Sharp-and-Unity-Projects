using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMDAAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            
            List<Employee> employees = new List<Employee>()
            {
                new Employee { FirstName = "Joe", LastName = "Smith", ID = 1 },
                new Employee { FirstName = "Joe", LastName = "York", ID = 2 },
                new Employee { FirstName = "Dan", LastName = "Polly", ID = 3 },
                new Employee { FirstName = "Bellinda", LastName = "Randalf", ID = 4 },
                new Employee { FirstName = "Francis", LastName = "Right", ID = 5 },
                new Employee { FirstName = "Joe", LastName = "Stand", ID = 6 },
                new Employee { FirstName = "Billy", LastName = "Quell", ID = 7 },
                new Employee { FirstName = "Gertrude", LastName = "Tormund", ID = 8 },
                new Employee { FirstName = "Jill", LastName = "Stein", ID = 9 },
                new Employee { FirstName = "Paul", LastName = "Helens", ID = 10 }
            };
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }
            foreach (Employee joe in JoeList)
            {
                Console.WriteLine(joe.EmployeeDetails());
            }
            List<Employee> EmployeeList = employees.Where(x => x.ID > 5).ToList();
            Console.WriteLine("\nList of Employees with Id over 5");
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine(employee.EmployeeDetails());
            }
            
            
            
            Console.ReadLine();
        }
    }
}
