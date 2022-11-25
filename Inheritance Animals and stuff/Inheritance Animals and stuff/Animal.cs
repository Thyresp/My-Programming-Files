using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Animals_and_stuff
{
    internal class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }
        //an empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {

        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is Eating");
            }

            else
            {
                Console.WriteLine($"{Name} is Not Hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is Playing");
        }


    }
}
