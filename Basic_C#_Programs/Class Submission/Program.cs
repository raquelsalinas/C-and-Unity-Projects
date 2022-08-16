using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 myclass = new Class1();

            Console.WriteLine("Enter a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());

            myclass.Divide(userValue);

            //Method using out parameters
            int i;
            myclass.Add(out i);

            Console.WriteLine("{0}", i);

            //Overloading methods
            Console.WriteLine(myclass.Area(5));
            Console.WriteLine(myclass.Area(5, 2));
            Console.ReadLine();
        }
    }
}
