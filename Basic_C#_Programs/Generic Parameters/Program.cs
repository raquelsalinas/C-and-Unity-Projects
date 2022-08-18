using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> e1 = new Employee<string>();
            e1.Things = new List<string>();

            e1.Things.Add("Red");
            e1.Things.Add("Orange");
            e1.Things.Add("Yellow");

            Employee<int> e2 = new Employee<int>();
            e2.Things = new List<int>();

            e2.Things.Add(0);
            e2.Things.Add(1);
            e2.Things.Add(2);

            foreach (string thing in e1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            foreach (int thing in e2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine();
        }
    }
}
