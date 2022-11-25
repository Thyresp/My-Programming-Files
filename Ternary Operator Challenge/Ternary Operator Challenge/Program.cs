using System;

namespace Ternary_Operator_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter a Tempature");
            string givenStringTempature = Console.ReadLine();
            if (Int32.TryParse(givenStringTempature, out int givenInt32))
            {
                Console.WriteLine($"Value Entered was {givenInt32}");
                string deneme = givenInt32 <= 15 ? "Too Cold" : givenInt32 > 28 ? "Too Hot" : "Average" ;
                Console.WriteLine(deneme);
            }
            else
            {
                Console.WriteLine("Sorry that was not a number");
            }

            
        }
    }
}
