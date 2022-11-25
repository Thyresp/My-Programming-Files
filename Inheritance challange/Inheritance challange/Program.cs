using System;

namespace Inheritance_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael","Miller",40000);

            michael.Work();
            michael.Pause();

            Boss Joe = new Boss("Joe", "Jonson", 100000, "Ford");

            Joe.Lead();

            Trainee michelle = new Trainee("Michelle", "Gartner", 10000, 32, 8);
            michelle.Learn();
            michelle.Work();
        }
    }
}
