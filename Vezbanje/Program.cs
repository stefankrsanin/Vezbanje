using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vezbanje.Program.Employee;

namespace Vezbanje
{
    internal class Program
    {
        public class Employee
        {
            public string name;
            public string lastName;
            public int age;

            public Employee(string _name, string _lastName, int _age)
            {
                name = _name;
                lastName = _lastName;
                age = _age;

                Console.WriteLine("This is employee with this parametar: ");
            }
        }
        public class Employee2 : Employee
        {
            public int salary;

            public Employee2(string _name, string _lastName, int _age, int _salary) : base(_name, _lastName, _age)
            {
                salary = _salary;
            }

        }
        public class Employee3 : Employee2
        {
            public string skill;

            public Employee3(string _name, string _lastName, int _age, int _salary, string _skill ) : base (_name, _lastName, _age, _salary)
            {
                
                skill = _skill;
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee("Stefan", "Krsanin", 28);
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.lastName);
            Console.WriteLine(emp.age);
            Employee2 emp2 = new Employee2("Stefan", "Krsanin", 28, 900);
            Console.WriteLine(emp2.name);
            Console.WriteLine(emp2.lastName);
            Console.WriteLine(emp2.age);
            Console.WriteLine(emp2.salary);
            Employee3 emp3 = new Employee3("Stefan", "Krsanin", 28, 900, "C#");
            Console.WriteLine(emp3.name);
            Console.WriteLine(emp3.lastName);
            Console.WriteLine(emp3.age);
            Console.WriteLine(emp3.salary);
            Console.WriteLine(emp3.skill);

        }
    }
}
