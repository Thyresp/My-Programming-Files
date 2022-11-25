using System;

namespace Learning_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameAssing;

            //Console.WriteLine("Please Enter Your Name and Press Enter");
            //nameAssing = Console.ReadLine();
            //Console.WriteLine(nameAssing.ToUpper());
            //Console.WriteLine(nameAssing.ToLower());
            //Console.WriteLine(nameAssing.Trim());
            //Console.WriteLine(nameAssing.Substring(2,6));

            //Console.WriteLine("Enter a string here: ");
            //string myString = Console.ReadLine();
            //Console.WriteLine("Enter the character to search");
            //char myChar = Console.ReadLine()[0];
            //Console.WriteLine("Location of The Given Character in String is: " + myString.IndexOf(myChar));

            //Console.WriteLine("Please enter First Name: ");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Now Please enter the Second Name: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine(firstName +" "+ lastName);

            //https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN
            byte myByte = 100;
            sbyte mySByte = -100;
            short myShort = -1000;
            ushort myUshort = 1000;
            int myInt = -10000;
            uint myUInt = 10000;
            long myLong = -100000;
            ulong myULong = 100000;
            float myFloat = 3.14f;
            double myDouble = 3.14159;
            char myChar = 'T';
            bool myBool = true;
            string myString = "Teoman";
            decimal myDecimal = 0;

            string text1 = "I Control The Text";
            string number1 = "123";
            Console.WriteLine(text1);
            Console.WriteLine(Int32.Parse(number1));

        }
    }
}
