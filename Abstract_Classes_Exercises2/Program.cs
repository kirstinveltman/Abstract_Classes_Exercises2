using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Zetter", Id = 1231 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Cahill", Id = 1232 });
            employees.Add(new Employee() { FirstName = "Wade", LastName = "Wilson", Id = 1233 });
            employees.Add(new Employee() { FirstName = "Steve", LastName = "Rogers", Id = 1234 });
            employees.Add(new Employee() { FirstName = "Diana", LastName = "Prince", Id = 1235 });
            employees.Add(new Employee() { FirstName = "Thor", LastName = "Odinnson", Id = 1236 });
            employees.Add(new Employee() { FirstName = "Natalia", LastName = "Romanova", Id = 1237 });
            employees.Add(new Employee() { FirstName = "Neena", LastName = "Thurman", Id = 1238 });
            employees.Add(new Employee() { FirstName = "Carol", LastName = "Danvers", Id = 1239 });
            employees.Add(new Employee() { FirstName = "Kamala", LastName = "Khan", Id = 1240 });

            // foreach loop
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }

            // lambda expression for "Joe"
            foreach (Employee employee in employees.FindAll(x => x.FirstName == "Joe"))
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            //// lambda expression for > 5
            foreach (Employee employee in employees.FindAll(x => x.Id > 5))
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();
        }
    }
}
