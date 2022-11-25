using System;

namespace Desicion_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats the tempature like?");
            int tempature;
            string placeHolder = Console.ReadLine();
            
            if (Int32.TryParse(placeHolder, out tempature))
            {
                Console.WriteLine("Alright Correct Value");
            }
            else 
            {
                tempature = 0;
                Console.WriteLine("Sorry Not A Number Tempature set to 0 by Default");
            }

            if (tempature < 10)
            {
                Console.WriteLine("Take the Coat");
            }

            else if (tempature == 10)
            {
                Console.WriteLine("Its 10 Degres C");
            }

            else
            {
                Console.WriteLine("Cozy and Warm");
            }

            string numberAsString = "128";
            int parseNumber;

            bool success = Int32.TryParse(numberAsString, out parseNumber);

            if (success)
            {
                Console.WriteLine("Number Converted it is {0}", parseNumber);
            }
            else
            {
                Console.WriteLine("It is Failed");
            }

        }
    }
}
