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

            Operations operation1 = new Operations();
            Operations operation2 = new Operations();
            Operations operation3 = new Operations();

            Console.WriteLine(operation1.Add(userInput), operation2.Subtract(userInput), operation3.Multiply(userInput));
            Console.ReadLine();
        }   
    }
}
