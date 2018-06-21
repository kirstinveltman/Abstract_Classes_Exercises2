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
            List<Employee> namedJoe = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    namedJoe.Add(employee);
                }
            }

            foreach (Employee j in namedJoe)
            {
                Console.WriteLine(j.FirstName + " " + j.LastName);
            }

            // lambda expression for "Joe"
            List<Employee> namedJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee j in namedJoe)
            {
                Console.WriteLine(j.FirstName + " " + j.LastName);
            }

            // lambda expression for > 5
            List<Employee> namedJoe = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee j in namedJoe)
            {
                Console.WriteLine(j.FirstName + " " + j.LastName);
            }
            Console.ReadLine();
        }
    }
}
