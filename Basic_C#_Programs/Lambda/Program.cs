using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { firstName = "John", lastName = "Smith", ID = 1 });
            employees.Add(new Employee() { firstName = "Mary", lastName = "Johnson", ID = 2 });
            employees.Add(new Employee() { firstName = "Janice", lastName = "King", ID = 3 });
            employees.Add(new Employee() { firstName = "Sean", lastName = "Williams", ID = 4 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Beam", ID = 5 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Sun", ID = 6 });
            employees.Add(new Employee() { firstName = "Karen", lastName = "Toller", ID = 7 });
            employees.Add(new Employee() { firstName = "Jessica", lastName = "Wallen", ID = 8 });
            employees.Add(new Employee() { firstName = "Maria", lastName = "Lopez", ID = 9 });
            employees.Add(new Employee() { firstName = "Justin", lastName = "Timberlake", ID = 10 });

            List<Employee> employees2 = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    employees2.Add(employee);
                }
            }
            foreach (Employee employee in employees2)
            {
                Console.WriteLine(employee.firstName);
            }







        }
    }
}
