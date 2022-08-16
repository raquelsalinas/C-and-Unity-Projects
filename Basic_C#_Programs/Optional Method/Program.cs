using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 myclass = new Class1();

            Console.WriteLine("Enter a value:");
            int valueOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another value or leave space blank and hit enter:");
            string userInput = Console.ReadLine();
            int valueTwo = 5;
            if (userInput != "")
            {
                valueTwo = Convert.ToInt32((userInput));

            }

            Console.WriteLine(myclass.Operation(valueOne, valueTwo));
            Console.ReadLine();
        }
    }
}
