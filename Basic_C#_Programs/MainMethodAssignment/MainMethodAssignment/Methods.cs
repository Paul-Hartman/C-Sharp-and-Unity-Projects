using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Methods
    {
        public static int Subtract(int input)
        {
            int diff1 = input - input;
            return (diff1);
        }
        public static float Subtract(float x, float y)
        {
            int diff2 = Convert.ToInt32(x - y);
            return (diff2);
        }
        public static int Subtract(string a, string b, string c)
        {
            int A =Convert.ToInt32(a);
            int B =Convert.ToInt32(b);
            int C =Convert.ToInt32(c);
            int diff3 = A-B-C;
            return (diff3);
        }
    }

}
