using System;

namespace LearningMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Argument");
            Console.WriteLine(Add(43, 23));
            Console.WriteLine(Multiplier(4, 3));
            Console.WriteLine(Division(41, 34));
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.WriteLine(LowUpper());
            Count();
            Console.WriteLine(UserAdd());

        }
        //accsess modifier (static) return type method name (parameter1, parameter2)

        public static void WriteSomething()
        { 
            Console.WriteLine("I am called from a method");
        }

        //so when we create a method its called parameter but when we call it its named argument
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Multiplier(int number1, int number2)
        {
            return number1 * number2; 
        }
       
        public static double Division(double number1, double number2)
        {
            return (number1 / number2);
        }

        static string friend1 = "Ahmet";

        static string friend2 = "Mehmet";

        static string friend3 = "Ali";

        public static void GreetFriend(string addfriend)
        {
            Console.WriteLine("Hello my dear friend {0}",addfriend);
        }




        public static string LowUpper()

        {
            string s = "HeY ThErE !";
            return s.ToLower() + s.ToUpper();
            }

        public static void Count()

        {
            string s = "HeY ThErE !";
            Console.WriteLine(s.Length);
        }

        public static int UserAdd()
        {
            Console.WriteLine("Please Enter the First Number");
            string placeHolder = Console.ReadLine();
            int firstNumber = Int32.Parse(placeHolder);
            Console.WriteLine("Please Enter the Second Number");
            string placeHolder2 = Console.ReadLine();
            int secondNumber = Int32.Parse(placeHolder2);
            return firstNumber + secondNumber;
        }




    }
}
