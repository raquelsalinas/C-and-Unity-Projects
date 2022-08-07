using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Class1
    {
        public int Math(int a)
        {
            int TotalA;
            TotalA = a + 5;
            return TotalA;
        }
        public int Math(double b)
        {
            double TotalB;
            TotalB = b - 5;
            return Convert.ToInt32(TotalB);
        }
        public int Math(string c)
        {
            int TotalC;
            TotalC = Convert.ToInt32(c) * 5;
            return TotalC;
        }
    }
}
