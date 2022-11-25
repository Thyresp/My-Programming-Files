using System;

namespace Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] {1, 2, 8, 155, 4};
            jaggedArray[1] = new int[] { 1, 7, 2 };
            jaggedArray[2] = new int[] { 61, 54 };

            // alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {7, 2, 76, 5132, 21},
                new int[] {95, 23, 5 }
            };

            /*Console.WriteLine(jaggedArray2[0][0]);
            Console.WriteLine(jaggedArray2[0][3]);
            Console.WriteLine(jaggedArray2[1][2]);*/

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray2[i][j]);
                }
            }

        }
    }
}
