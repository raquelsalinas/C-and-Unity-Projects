using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Class1
    {
        public int Add(int x)
        {
            int total;
            total = x + 5;
            return total;
        }

        public int Subtract(int y)
        {
            int total2;
            total2 = y - 5;
            return total2;
        }

        public int Multiply(int z)
        {
            int total3;
            total3 = z * 5;
            return total3;
        }
    }
}
