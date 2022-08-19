using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Employee
    {
        public int Id { get; set; }

        public static bool operator == (Employee myEmployee, Employee myEmployee2)
        {
            if (myEmployee.Id == myEmployee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee myEmployee, Employee myEmployee2)
        {
            if (myEmployee.Id != myEmployee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

