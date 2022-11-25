using System;

namespace Deneme_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 15;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too Young to Enter");
                    break;

                case 25:
                    Console.WriteLine("Alright Can Enter");
                    break;
                default:
                    Console.WriteLine("How Old are you I cant Figure it out");
                    break;
            }

            if (age == 25)
            {
                Console.WriteLine("Alright Can Enter");
            }
            else if (age == 15)
            {
                Console.WriteLine("Too Young to Enter");
            }
            else
            {
                Console.WriteLine("How Old are you I cant Figure it out");
            }

        }
    }
}
