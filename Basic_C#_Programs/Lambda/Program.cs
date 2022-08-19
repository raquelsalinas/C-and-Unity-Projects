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

            foreach (var data in employees)
            {
                if (data.firstName == "Joe")
                {
                    Console.WriteLine("Joe's last name is {0} and ID number is {1}", data.lastName, data.ID);
                }
            }

            List<Employee> employee2 = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee employee in employee2)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);
            }

            List<Employee> employee3 = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in employee3)
            {
                Console.WriteLine("Employees with ID greater than 5:");
                Console.WriteLine("{0} {1} ID:{2}", employee.firstName, employee.lastName, employee.ID);

            }
            Console.ReadLine();
        }
    }
}
