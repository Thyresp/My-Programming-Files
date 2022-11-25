using System;

namespace Inheritance_Animals_and_stuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sif", 7);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
