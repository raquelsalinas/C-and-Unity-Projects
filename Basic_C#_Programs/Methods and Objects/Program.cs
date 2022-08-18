using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee
            {
                Id = 001
            };

        Employee myEmployee2 = new Employee 
            {
                Id = 002
            };

            Console.WriteLine("Both employees have" + ((myEmployee == myEmployee2) ? "the same IDs" : "different IDs"));
            Console.ReadLine();
        }
    }
}
