using System;

namespace Challange_Baby_Teacher_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType = String.Empty;

            Console.WriteLine("Enter a value");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate");
            Console.WriteLine("1 for string");
            Console.WriteLine("2 for integer");
            Console.WriteLine("3 foe boolean");

            Console.WriteLine("Enter :");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    Console.WriteLine("Didnt enter 1,2,3 unable to detect");
                    break;
            }

            Console.WriteLine($"You have entered a value : {inputValue}");
            if (valid)
            {
                Console.WriteLine($"It is valid : {inputValueType}");
            }
            else
            {
                Console.WriteLine($"It is invalid : {inputValueType}");
            }

        }
        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }

    }

}
