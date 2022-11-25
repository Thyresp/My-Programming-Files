using System;

namespace Multi_Dimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2D array
            string[,] matrix;

            //3D array
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3}, //row0
                {4, 5, 6}, //row1
                {7, 8, 9}  //row2
            };

            string[,,] array3D = new string[,,]
            {
                {
                    {"sfsdf","dasffds"},
                    {"223dda","dfsa*d" },
                    {"0dfsfda","dsfdssa" }
                },
                {
                    {"sdfdfsa","dsfa342f"},
                    {"fdaf2dg43","fdsasf"},
                    {"adfsfd","afdas21"}
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                {"1","2"},{"3","4"},{"5","6"}
            };

            array2DString[1, 1] = "chicken";

            int dimesions = array2DString.Rank;

            Console.WriteLine($"Central value is {array2D[1,1]}");
            Console.WriteLine(array2D[2,0]);
            Console.WriteLine(array3D[0,2,0]);
            Console.WriteLine(array2DString[1,1]);
            Console.WriteLine(dimesions);
        }
    }
}
