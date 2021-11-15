using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Methods
    {
        public void Divide(int a)
        {
            int result = a / 2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public int OutArgExample(int a, out int number)
        {
            number = 44 *a;
            return number;
        }

        public int OutArgExample(int a, int b, out int answer)
        {
            answer = a + b;
            return answer;
        }



    }
}
