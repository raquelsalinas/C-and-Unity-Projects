﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
