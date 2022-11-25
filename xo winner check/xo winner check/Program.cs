using System;

namespace xo_winner_check
{
    internal class Program
    {
        static string[,] xoChecker =
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };

        static void Main(string[] args)
        {


            if (xoChecker[0,0] == xoChecker[1,1] && xoChecker[1,1] == xoChecker[2,2])
            {
                Console.WriteLine("Game Finished (Diagonal)");
            }
            else if(xoChecker[0,2] == xoChecker[1,1] && xoChecker[1,1] == xoChecker[2,0])
            {
                Console.WriteLine("Game Finished (Diagonal)");
            }


            for (int i = 0; i < xoChecker.GetLength(0); i++)
            {

                if (xoChecker[0,i] == xoChecker[1,i] && xoChecker[1,i] == xoChecker[2,i] )
                {
                    Console.WriteLine("Game Finished (Vertical)");
                }
                if (xoChecker[i,0] == xoChecker[i,1] && xoChecker[i,1] == xoChecker[i,2])
                {
                    Console.WriteLine("Game Finished (Horizontal)");
                }
            }
        }
    }
}
