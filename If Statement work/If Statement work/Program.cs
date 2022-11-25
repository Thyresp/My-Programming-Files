using System;

namespace If_Statement_work
{
    internal class Program
    {
        static string highestScoreUser = "Mehmet";
        static int highestScore = 60;

        static void Main(string[] args)
        {
            GamerScore(70, "Ahmet");
        }
        public static void GamerScore(int highScore, string playerName)
        {
            if (highScore > highestScore)
            {
                highestScore = highScore;
                Console.WriteLine($"New High Score is {highestScore}");
                highestScoreUser = playerName;
                Console.WriteLine($"And The New High Score Holder is {highestScoreUser}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highestScore} could not be broken and is still held by {highestScoreUser}");
            }
        }
    }
}
