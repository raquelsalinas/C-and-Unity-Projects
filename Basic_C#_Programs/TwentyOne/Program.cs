using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            var userInput = Convert.ToInt32(Console.ReadLine());

            Class1 myclass = new Class1();

            Console.WriteLine(myclass.Add(userInput));
            Console.WriteLine(myclass.Subtract(userInput));
            Console.WriteLine(myclass.Multiply(userInput));
            Console.ReadLine();
        }   
    }
}
