using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Animals_and_stuff
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog (string name, int age):base(name,age)
        {
            IsHappy = true;
        }

        //simple override of the virtual method Eat
        public override void Eat()
        {
            // to call the eat method from our base class we use keyword "base"
            base.Eat();
        }

        //override of the virtual method MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Woof!! Woof!!");
        }

        public override void Play()
        {
            //check if the dog is happy if yes then call the Play Method from the Base Class
            if (IsHappy)
            {
                base.Play();
            }
            
        }

    }
}
