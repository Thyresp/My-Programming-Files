using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_challange
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        
        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }
        public Employee()
        {
            Name = "Öztürk";
            FirstName = "Teoman";
            Salary = 1000;
        }

        public virtual void Work()
        {
            Console.WriteLine("I am Working");
        }

        public void Pause()
        {
            Console.WriteLine("I am having a break");
        }

    }
}
