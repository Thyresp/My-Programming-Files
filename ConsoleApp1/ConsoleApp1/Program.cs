using System;

namespace ConsoleApp1
{
    //Constants are immutable values whic are known at
    //compile time an do not change for the life of the program
    internal class Program
    {
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "13/07/2002";



        static void Main(string[] args)
        {
            Console.WriteLine(myBirthday);
        }
    }
}
