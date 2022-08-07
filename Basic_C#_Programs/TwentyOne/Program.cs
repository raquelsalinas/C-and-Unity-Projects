using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            var userInput = Convert.ToInt32(Console.ReadLine());

            Operations operation = new Operations();

            Console.WriteLine(operation.Add(userInput), operation.Subtract(userInput), operation.Multiply(userInput));
            Console.ReadLine();
        }   
    }
}
