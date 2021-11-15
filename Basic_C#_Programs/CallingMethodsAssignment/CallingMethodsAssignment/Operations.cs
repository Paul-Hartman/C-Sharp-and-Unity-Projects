using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Operations
    {
        public int Square(int enteredNumber)
        {
            int input = enteredNumber;
            return input * input;
        }

        public int AddSub(int enteredNumber)
        {
            int input = enteredNumber;
            if (enteredNumber > 30)
            {
                int sum = input - 10;
                return (sum);
            }
            else
            {
                int sum = input + 15;
                return (sum);
            }
            
        }

        public int IsOdd(int enteredNumber)
        {
            int OddorEven = enteredNumber % 2;
            return (OddorEven);
        }
        
    }
}
