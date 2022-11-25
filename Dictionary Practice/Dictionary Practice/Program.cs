using System;
using System.Collections.Generic;

namespace Dictionary_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> myDictionary = new Dictionary<int, string>()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three"},
                {4,"Four"},
                {5,"Five"}
            };

            string stringNumber = Console.ReadLine();
            Int32.TryParse(stringNumber, out int number);
            if (myDictionary.ContainsKey(number))
            {
                Console.WriteLine(myDictionary[number]);
            }
            else
            {
                Console.WriteLine("Nope");
            }
        }
    }
}
