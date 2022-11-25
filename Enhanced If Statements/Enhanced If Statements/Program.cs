using System;

namespace Enhanced_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condition ? first_expression : second_expression;
            //condition has to be either true or false
            //The conditional operator is right - associative
            //The expression a ? b: c? d: e
            //is evaluated as a ? b : (c ? d : e)
            //not as (a? b : c) ? d: e
            //The conditional operator cannot be overloaded

            //in celcius
            int tempature = -5;
            string stateOfMatter;

            if (tempature < 0)
                stateOfMatter = "Solid";
            else
                stateOfMatter = "Liqiud";

            Console.WriteLine(stateOfMatter);

            tempature += 30;

            //in short
            stateOfMatter = tempature < 0 ? "Solid" : "Liqiud";
            Console.WriteLine(stateOfMatter);

            tempature += 100;


            stateOfMatter = tempature > 100 ? "Gas" : tempature < 0 ? "Solid" : "Liqiud";
            Console.WriteLine(stateOfMatter);


        }
    }
}
