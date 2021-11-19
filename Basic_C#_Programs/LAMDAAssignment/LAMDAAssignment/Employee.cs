using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMDAAssignment
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string EmployeeDetails ()
        {
            return string.Format("{0} {1} ID: {2}",
                FirstName, LastName, ID);
        }


    }
    }


