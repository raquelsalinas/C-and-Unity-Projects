using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myclass = new Class1();
            Console.WriteLine(myclass.Math(5));
            Console.WriteLine(myclass.Math2(5));
            Console.WriteLine(myclass.Math3(5));
            Console.ReadLine();
        }
    }
}
