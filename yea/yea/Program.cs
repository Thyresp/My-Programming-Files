using System;

namespace yea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            Console.WriteLine(GetAverage(studentsGrades));

            int[] arrayOfHappiness = new int[] { 1, 2, 3, 4, 5 };

            SunIsShining(arrayOfHappiness);

            foreach (int numbers in arrayOfHappiness)
            {
                Console.WriteLine(numbers);
            }

            
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average = 0;
            int sum = 0;

            for (int i = 0; i< size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void SunIsShining(int[] rateArray)
        {

            for (int i =0; i<rateArray.Length; i++)
            {
                rateArray[i] += 2;
            }
        }
    }
}
