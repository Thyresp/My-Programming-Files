using System;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NestedCheck(1);
            RegistireLoginUser();
            static void NestedCheck(int number)
            {
                if (number % 3 == 0)
                {
                    System.Console.WriteLine("Divisible by 3.");
                }
                else if (number % 7 == 0)
                {
                    System.Console.WriteLine("Divisible by 7.");
                }
                else
                {
                    if (number % 2 != 0)
                    {
                        System.Console.WriteLine("Odd number.");
                    }
                    else
                    {
                        System.Console.WriteLine("Even number.");
                    }
                }
            }




            static void RegistireLoginUser()
            {
                Console.WriteLine("Please Enter UserName for Registiration");
                string userName = Console.ReadLine();
                Console.WriteLine("Now Please Enter Password");
                string password = Console.ReadLine();

                Console.WriteLine("Now Please Login For Confirmation");
                Console.WriteLine("UserName:");
                 

                if(userName == Console.ReadLine())
                {
                    Console.WriteLine("User Found Now Please Enter");
                    Console.WriteLine("Password:");
                    if (password == Console.ReadLine())
                    {
                        Console.WriteLine($"Welcome Back {userName}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry Something was Wrong Please try Again");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry No User found");
                }
            }


            }
        }
    }

