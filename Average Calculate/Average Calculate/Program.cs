using System;

namespace Average_Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a value between 0 to 20 to calculate average score (Enter -1 to finish)");
            string stringNote = "";
            int numberOfTimesEntered = 0;
            int sum = 0;
            while (stringNote != "-1")
            {
                stringNote = Console.ReadLine();
                
                if (Int32.TryParse(stringNote, out int numberNote))
                {

                    if (numberNote > -1 && numberNote < 21)
                    {
                        Console.WriteLine(++numberOfTimesEntered);
                        Console.WriteLine(sum = sum + numberNote);
                        
                    }
                    else if (numberNote == -1)
                    {
                        Console.WriteLine("Thats all folks!");
                        int calculation = sum / numberOfTimesEntered;
                        Console.WriteLine(calculation);

                    }
                    else
                    {
                        Console.WriteLine("Sorry You Have to enter Numbers Between 0 to 20");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry Thats Not a Number");
                }
            }
        }
    }
}
