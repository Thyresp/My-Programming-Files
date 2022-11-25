using System;

namespace Min_value_using_params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //there is a Math.Min() class that we can use to compare and get the minimum value but it can only take a limited amount of parameters
            //but with our own method with params we can take as many parameters as possible

            

            Console.WriteLine(MinV2(6, 8, 4, 2, 0, 1, 5));
        }


        public static int MinV2(params int[] number)
        {
            int min = int.MaxValue;

            foreach (int i in number)
            {
                if (i < min)
                {
                    min = i;
                }

            }
            return min;


        }

    }


}
