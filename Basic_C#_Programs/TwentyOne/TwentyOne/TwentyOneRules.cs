﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two]= 2,
            [Face.Three]= 3,
            [Face.Four]= 4,
            [Face.Five]= 5,
            [Face.Six]= 6,
            [Face.Seven]= 7,
            [Face.Eight]= 8,
            [Face.Nine]= 9,
            [Face.Ten]= 10,
            [Face.Jack]= 11,
            [Face.Queen]= 12,
            [Face.King]= 13,
      
            
        };
    }
}
