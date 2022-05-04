using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Optional_Parameters
{
    public class AnotherClass
    {
        public int AnotherDollar(int x, int y = 1)
        {
            int z = x * y;
            return z;
        }
    }
}
