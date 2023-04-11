using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                Console.WriteLine("This is emplyee with this parametar: ");
            }

        }

        static void Main(string[] args)
        {
            
            Employee emp = new Employee("Stefan", "Krsanin", 28);
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.lastName);
            Console.WriteLine(emp.age);
        }
    }
}
