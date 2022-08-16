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
            Employee myEmployee = new Employee();

            myEmployee.firstName = "Sample";
            myEmployee.lastName = "Student";
            myEmployee.SayName();

            Console.ReadLine();
        }
    }
}
