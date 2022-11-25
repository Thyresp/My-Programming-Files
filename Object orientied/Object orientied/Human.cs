using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orientied
{
    //this class is a bluprint for a datatype
    internal class Human
    {
        //now with constructor these can be private
        //member variable
        private string firstName;

        private string lastName;

        private int age;

        private string eyeColor;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }


        //parameterized constructor
        public Human(string myFirstName, string lastName, int age, string eyeColor)
        {
            //two different way to do
            firstName = myFirstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        public Human(string myFirstName, string lastName, string eyeColor)
        {
            
            firstName = myFirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string myFirstName, string lastName)
        {

            firstName = myFirstName;
            this.lastName = lastName;
        }

        public Human(string firstName)
        {

            this.firstName = firstName;

        }

        //member method
        public void IntroduceMyself()
        {
            if (age != 0)
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName}");
                Console.WriteLine($"I am {age} years old and my eye color is {eyeColor}");
            }

            else if (age == 0 && eyeColor == null && lastName == null)
            {
                Console.WriteLine($"Hi I'm {firstName} my last name is unkown");
                Console.WriteLine($"My age is unknown and my eye color is unknown");
            }


            else if (age == 0 && eyeColor == null)
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName}");
                Console.WriteLine($"My age is unknown and my eye color is unknown");
            }

            else if (age == 0)
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName}");
                Console.WriteLine($"My age is unknown and my eye color is {eyeColor}");
            }

        }

        
    }
}
