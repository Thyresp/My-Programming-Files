using System;

namespace Decision_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter User Name");
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("You are already Registered");
                if (userName != "")
                {
                    Console.WriteLine($"Welcome back {userName}");
                    if (isAdmin)
                    {
                        Console.WriteLine("You are a admin you carry the responsibility");
                    }
                }
            }

            if (isRegistered && userName != "" && isAdmin)
            {
                Console.WriteLine("You are already Registered");


                Console.WriteLine($"Welcome back {userName}");


                Console.WriteLine("You are a admin you carry the responsibility");

            }
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are Logged");
            }


        }
    }
}
