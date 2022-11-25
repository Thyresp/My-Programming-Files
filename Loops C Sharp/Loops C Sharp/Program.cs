using System;

namespace Loops_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop
            //for(start value; condition; increment){ }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For Loop is done");

            for (int i = 1; i < 20; i += 2) 
            {
                Console.WriteLine(i); 
            }

            //do while loop
            int counter = 150;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 100);
            Console.WriteLine("As you can see do while loop first runs the code then checks for condition");

            int lenghtOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please Enter the name of a Friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfAFriend;
            } while (lenghtOfText < 20);
            Console.WriteLine($"Thank you, that was enough {wholeText}");

            //while loop

            int counter2 = 0;
            while(counter2 < 10)
            {
                Console.WriteLine(counter2);
                counter2++;
            }


            //benim çözümüm

            int busCounter = 0;
            while (busCounter < 10)
            {
                Console.WriteLine(busCounter);
                if (Console.ReadLine() == "")
                {
                    busCounter++;
                }
                else
                {
                    Console.WriteLine("Alright Everybody is in");
                    busCounter = 10;
                }
            }

            //öğretmenin çözümü
            int busCounter2 = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Enter to Count anything else to finish");
                enteredText = Console.ReadLine();

                busCounter2++;
                Console.WriteLine($"Current people count is {busCounter2}");
            }
        }
    }
}
