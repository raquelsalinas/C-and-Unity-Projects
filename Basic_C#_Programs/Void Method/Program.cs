using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myclass = new Class1();

            myclass.Operation(2, 3);
            
            myclass.Operation(secondNumber: 10, firstNumber: 12);

            Console.ReadLine();
        }
    }
}
