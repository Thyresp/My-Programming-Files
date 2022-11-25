using System;

namespace Challange_Baby___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a value:");
            string enteredValue = Console.ReadLine();
            Console.WriteLine("Now Please Select its type (1.String ,2.Integer ,3.Boolean)");
            string selection = Console.ReadLine();



                bool check = Int32.TryParse(selection, out int intSelection);
            if (check)
            {
                switch (intSelection)
                {
                    case 1:
                        if (enteredValue.Length != 1)
                        {
                            Console.WriteLine($"Entered Value is {enteredValue}");
                            Console.WriteLine("And Its Valid String");
                        }
                        else
                        {
                            Console.WriteLine($"Entered Value is {enteredValue}");
                            Console.WriteLine("And Its Not String");
                        }
                        break;
                    case 2:
                        bool intCheck = Int32.TryParse(enteredValue, out int intOutput);
                        if (intCheck)
                        {
                            Console.WriteLine($"Entered Value is {enteredValue}");
                            Console.WriteLine("And Its Valid Integer");
                        }
                        else
                        {
                            Console.WriteLine($"Entered Value is {enteredValue}");
                            Console.WriteLine("And Its Not Integer");
                        }
                        break;
                    case 3:
                        bool boolCheck = bool.TryParse(enteredValue, out bool boolOutput);
                        if (boolCheck)
                        {
                            Console.WriteLine($"Entered Value is {enteredValue}");
                            Console.WriteLine("And Its Valid Boolean");
                        }
                        else
                        {
                            Console.WriteLine($"Entered Value is {enteredValue}");
                            Console.WriteLine("And Its Not Boolean");
                        }
                        break;
                    default:
                        Console.WriteLine("Sorry Number You Have Entered was not between (1-3)");
                        break;
                }
            }
            else
            {
                    Console.WriteLine("Sorry Thats not a number");
            }
        }
    }
}
