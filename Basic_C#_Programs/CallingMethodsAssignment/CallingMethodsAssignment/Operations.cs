using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Operations
    {
        static public int Square(int enteredNumber)
        {
            int input = enteredNumber;
            return input * input;
        }

        static public int AddSub(int newNum)
        {
            int input = newNum;
            if (newNum > 30)
            {
                newNum = newNum - 10;
            }
            else
            {
                newNum = newNum + 15;
            }
            return (newNum);
        }

        static public int IsOdd(int newNum)
        {
            int OddorEven = newNum % 2;
            return (OddorEven);
        }
        
    }
}
