using System;

namespace DotNet5App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Naming Convention is Differrent than Python So At First I wrote Like Python Hopefully it will change in the future
             For Class Names I should use PascalCasing example: ClientActivity
             Same for Method names like: CalculateValue
            
             For method arguments use camelCasing: firstNumber 
             and for local Variables like: itemCount
            
             Dont do Abbrevation
            USE userControl NOT usrCntr
            Try to avoid Under Score( _ ) Except at the beggining
             */


            //sbyte (whole numbers from -128 to 127)
            //short (whole numbers from -32767 to 32767)
            //int (whole numbers from -2,147,483,648 to 2,147,483,647)
            //long (-9,223,327,036,854,775,808 to -9,223,327,036,854,775,807)

            //float(7-digit precision)
            //double(15-digit precision)
            //decimal(28-digit precision)

            //declaring a variable 
            int num1;
            //assinging a variable
            num1 = 13;
            // doing both at the same time
            int num2 = 23;
            //declaring multiple variables
            int num3, num4, num5;
            //overwriting a variable
            num2 = 100;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Teo!");
            Console.WriteLine("Lets Begin!");
            int sum = num1 + num2;
            Console.WriteLine(sum);
            //using concentination
            Console.WriteLine("num1 is equal to: " + num1);
            
            //for higher precision use double
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is: " + dDiv);
            
            //for lower precision use float(it also uses less memory)
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is: " + fDiv);

            //dividing a double with integer
            double DIdiv = d1 / num1;
            Console.WriteLine(DIdiv);

            string myName = "Teo";

            string message = "Hello My Name is: ";

            string conMessagge = message + myName;

            string upperMessagge = conMessagge.ToUpper();  

            Console.WriteLine(upperMessagge);

            Console.Write("Please Enter String: ");
            //.ReadLine gets user input
            string userInput = Console.ReadLine();
            Console.WriteLine("You Have Entered {0}",userInput);

            Console.Write("Please Enter a Character: ");
            int asciiVal = Console.Read();
            Console.WriteLine("Characters ascii value is:{0} ", asciiVal);

            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Deneme123");
            Console.Clear();
            


            //implicit Convertion
            int myNumber = 13432145;
            long myNewLongNumber = myNumber;

            float myDecimal = 13.45f;
            double myNewDoubleDecimal = myDecimal;

            //explicit Convertion
            double pi = 3.14159;
            int integerPi;
            //casting double to int
            integerPi = (int)pi;
            Console.WriteLine(integerPi);

            //type Convertion
            string myString = pi.ToString();
            string myString2 = myDecimal.ToString();
            Console.WriteLine(myString);

            //Parsing
            string myString3 = "13";
            string myString4 = "15";

            int stringToInt = Int32.Parse(myString3);
            int stringToInt2 = Int32.Parse(myString4);
            int newString = stringToInt + stringToInt2;
            Console.WriteLine(newString);

            int age = 20;

            string name = "Teo";
            string job = "Developer";


            //string concatination
            Console.WriteLine("Hello my Name is "+ name +" and my age is "+ age );

            //ı guess it is String.Format()
            //string formatting
            Console.WriteLine("Hello my Name is {0} and my age is {1}. Also my job is {2}",name,age,job);

            //string interpletion
            //use dollar sign in the beggining
            Console.WriteLine($"Hello my Name is {name} and my age is {age}");

            //verbatim strings
            //use @ sing in the beggining
            //takes the string literary ı guess we could also say 1 to 1
            Console.WriteLine(@"Deneme 123
                              Boşluk    
                                
                              Öldüm galiba");

            string deneme = "omgbebi";
            deneme = deneme.Substring(2);
            Console.WriteLine(deneme);
            Console.WriteLine(deneme.IndexOf("i"));

            string name1 = "Dennis";
            string name2 = "Panjuta";
            string fullName = string.Concat(" ",name1,name2," ");
            Console.WriteLine(fullName);
            //Trim Removes White spaces in the beggining or at the end of the Word Not Middle
            Console.WriteLine(fullName.Trim());

        }
    }
}
