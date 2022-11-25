using System;

namespace Metohds_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = Int32.Parse(userInput);
                //int divideByZero = userInputAsInt / 0;
            }
            catch (FormatException)
            {

                Console.WriteLine("Format Exception Please Enter Correct Type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverFlow Exception Either too large or too small value");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tried to Divide to Zero");
            }

            finally
            {
                Console.WriteLine("I get run even if there was error or no error");
            }

            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operator
            num3 = -num2;
            Console.WriteLine("num3 is {0}",num3);

            bool isSunny = true;
            Console.WriteLine("Is it Sunnt Outside ?\nAnswer:{0}",!isSunny);

            //increment operator
            int num = 0;
            num++;
            Console.WriteLine(num);
            //post increment
            Console.WriteLine(num++);
            Console.WriteLine(num);
            Console.WriteLine(num);
            //pre increment
            Console.WriteLine(++num);


            //decrement operator
            num--;
            Console.WriteLine(num);
            //post decrement
            Console.WriteLine(num--);
            Console.WriteLine(num);
            Console.WriteLine(num);
            //pre decrement
            Console.WriteLine(--num);


            int result;

            result = num1 + num2;
            Console.WriteLine("num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("num1 / num2 is {0}(no rounding it just cuts of (we need a double))", result);
            result = num1 * num2;
            Console.WriteLine("num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("num1 % num2 is {0}(gives us the remainder of the division)", result);

            //relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("num1 > num2 is {0}", isLower);

            //equality operator
            bool isEqual = num1 == num2;
            Console.WriteLine("num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("num1 != num2 is {0}", isEqual);

            //conditional operators
            bool isLowerAndSunny;
            //And Condition(Both Needs to Be True)
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("isLower && isSunny is {0}", isLowerAndSunny);

            //Or Condition(One of Them Needs To be True)
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("isLower || isSunny is {0}", isLowerAndSunny);
        }
    }
}
