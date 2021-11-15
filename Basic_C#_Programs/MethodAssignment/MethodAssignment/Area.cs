using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Area
    {
        public int area (int l)
        {
            int area = l * l;
            return area;
        }
        public int area(int l, int w)
        {
            int area = l * w;
            return area;
        }
    }
}
