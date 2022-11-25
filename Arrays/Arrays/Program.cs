using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];


            grades[0] = 14;
            grades[1] = 2;
            grades[2] = 19;
            grades[3] = 7;
            grades[4] = 20;

            Console.WriteLine($"Grade at index zero is {grades[0]}");


            //another way of initializing
            int[] grades2 = {2,5,20,7,19,17,15};

            int[] grades3 = new int[] {2,3,17,20,16,14,5};

            Console.WriteLine(grades2.Length);


        }
    }
}
