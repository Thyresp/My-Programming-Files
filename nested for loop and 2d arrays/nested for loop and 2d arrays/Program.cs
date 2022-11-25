using System;

namespace nested_for_loop_and_2d_arrays
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3}, //0,2
            {4,5,6}, //1,1
            {7,8,9}  //2,0
        };

        static void Main(string[] args)
        {
            //foreachloop is good for displaying someting but not spescificly changing the item itself
            foreach (int x in matrix)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine(" \n This is our 2D array printed using nested for loop");
            //Nested for loop
            //outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //in this case ı can assing a nev value to it for example
                    //matrix[i,j] = 0;
                    //Console.Write(matrix[i,j] + " ");
                    
                    /*if (matrix[i,j] % 2 == 0)
                    {
                        Console.WriteLine(matrix[i,j]);
                    }*/
                    
                    /*if (i == j)
                    {
                        Console.WriteLine(matrix[i,j]);
                    }*/


                }

            }
            /*for (int k = 0; k < matrix.GetLength(0); k++)
            {
                Console.WriteLine(matrix[k, k]);
            }*/

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++ ,j--)
            {
                Console.WriteLine(matrix[i,j]);
            }
        }
    }
}
