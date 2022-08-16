using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    public class Class1
    {
        public void Divide(int data)
        {
            int total = data / 2;
            Console.WriteLine(total);
        }

        //Method using out parameters
        public void Add(out int i)
        {
            i = 30;
            i += i;
        }

        //Overloading methods
        public double Area(double s)
        {
            double Area = s * s;
            return Area;
        }

        public double Area(double x, double y)
        {
            double Area = x * y;
            return Area;
        }
    }
}
