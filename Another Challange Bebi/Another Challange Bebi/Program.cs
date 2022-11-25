using System;

namespace Another_Challange_Bebi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] familyArray = new string[3][];

            familyArray[0] = new string[] {"Ahmet","Mehmet"};
            familyArray[1] = new string[] { "Necati", "Zeynep" };
            familyArray[2] = new string[] { "Hazel", "Simay" };

            Console.WriteLine($"Bu {familyArray[0][0]} ve buda {familyArray[1][1]}");
            Console.WriteLine($"Bu {familyArray[0][1]} ve buda {familyArray[1][0]}");
            Console.WriteLine($"Bu {familyArray[2][0]} ve buda {familyArray[2][1]}");
        }
    }
}
