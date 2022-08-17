using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Employee : Person, iQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
