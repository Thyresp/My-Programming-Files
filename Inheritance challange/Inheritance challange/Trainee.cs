using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_challange
{
    internal class Trainee : Employee
    {
        public int WorkHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string name, string firstName, int salaryint ,int workHours, int schoolHours): base(name,firstName,salaryint)
        {
            WorkHours = workHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I am learnig for {0} hours", SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine($"Working Hours of {Name} is {WorkHours}");
        }
    }
}
