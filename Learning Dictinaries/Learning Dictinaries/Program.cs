using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_Dictinaries
{
    internal class Program
    {
        //key - value
        //auto - car


        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO","Gwyn",95,200),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lora",32,21),
                new Employee("Secretary","Petra",28,18),
                new Employee("Lead Developer","Artorias",55,35),
                new Employee("Intern","Ernest",22,8)

            };

            /*Dictionary<int, string> myDictionary = new Dictionary<int, string>() 
            {
                {1,"one"},
                {2,"two"},
                {3,"three"},
            };*/

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }

            string key = "CEO";
            if (employeeDirectory.ContainsKey(key)) 
            {
                Employee empl = employeeDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No Employee found");
            }

            //another way for checking if the key exist or not
            Employee result = null;
            if (employeeDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Employe Name {0} " ,result.Name);
                Console.WriteLine("Employe Role {0} ", result.Role);
                Console.WriteLine("Employe Age {0} ", result.Age);
                Console.WriteLine("Employe Salary {0} ", result.Salary);
            }
            else 
            { 
                Console.WriteLine("The Key Doesnt Exits"); 
            }

            //Complicated but this is just another way to acces an item inside of your dictionary not using the key as a string,but the key as an intiger that is assinged to it
            for (int i = 0; i < employeeDirectory.Count; i++)
            {
                //using ElementAt(i) to return the key value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);
                //print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                //storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine(employeeValue.Name);
                Console.WriteLine(employeeValue.Role);
                Console.WriteLine(employeeValue.Age);
                Console.WriteLine(employeeValue.Salary);
            }

            //updating a dictionary
            string KeyToUpdate = "HR";
            if (employeeDirectory.ContainsKey(KeyToUpdate))
            {
                employeeDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!",KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No Employee found with this key {0}", KeyToUpdate);
            }

            //removing key/value from a dictionary
            string KeyToRemove = "Intern";
            if (employeeDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was removed!", KeyToRemove);
            }


        }

        class Employee
        {
            // few properties like Role, Name, Age and Rate
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public float Rate { get; set; }
            //yearly salary calcultation
            public float Salary
            {
                get 
                { 
                    return Rate * 8 * 5 * 4 *12; 
                }
            }
            public Employee(string role, string name, int age, float rate)
            {
                this.Role = role;
                this.Name = name;
                this.Age = age;
                this.Rate = rate;
            }
            //simple Constructor





        }

    }
}
