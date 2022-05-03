using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method_Submission
{
    public class QuickAdd
    {
        public int Math(int x)//initial method
        {
            int y = x + 11;

            return y;
        }

        public int Math(decimal x)//first overload
        {
            int y = Convert.ToInt32(x) - 5;

            return y;
        }
        public int Math(string x)//second overload
        {
            int y = Convert.ToInt32(x);
            y /= 2;

            return y;
        }
    }
}
