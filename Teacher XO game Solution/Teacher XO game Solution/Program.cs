using System;

namespace Teacher_XO_game_Solution
{
    internal class Program
    {
        static char[,] playField =
        {
            {'7','8','9'},
            {'4','5','6'},
            {'1','2','3'}
        };



        static int turns = 0;

        static void Main(string[] args)
        {

            int player = 2; //Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            

            //Run code as long as the program runs
            do
            {
                
                //switches between player 1 and 2 to go in order
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                SetField();

                #region
                //Checks for winning condition
                char[] playerChars = { 'X', 'O' };

                foreach (char c in playerChars)
                {
                    if (((playField[0, 0] == c) && (playField[0, 1] == c) && (playField[0, 2] == c)) 
                        || ((playField[1, 0] == c) && (playField[1, 1] == c) && (playField[1, 2] == c))
                        || ((playField[2, 0] == c) && (playField[2, 1] == c) && (playField[2, 2] == c))
                        || ((playField[0, 0] == c) && (playField[1, 0] == c) && (playField[2, 0] == c))
                        || ((playField[0, 1] == c) && (playField[1, 1] == c) && (playField[2, 1] == c))
                        || ((playField[0, 2] == c) && (playField[2, 1] == c) && (playField[2, 2] == c))
                        || ((playField[0, 0] == c) && (playField[1, 1] == c) && (playField[2, 2] == c))
                        || ((playField[0, 2] == c) && (playField[1, 1] == c) && (playField[2, 0] == c))
                        )

                    {
                        if (c == 'X')
                        {
                            Console.WriteLine("Player 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("Player 1 has won!");
                        }

                        Console.WriteLine("Please Press Anykey to Reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if(turns == 10)
                    {
                        Console.WriteLine("Draw!!");
                        Console.WriteLine("Please Press Anykey to Reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

                #endregion

                #region
                do
                {
                    Console.WriteLine($"\nPlayer {player} Choose your field! ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a Number!");
                    }

                    //checks if the place is occupied
                    if ((input == 1) && (playField[2, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[2, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[2, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[0, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[0, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[0, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nIncorrect Input Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion


            } while (true);


        }
        public static void ResetField()
        {
            char[,] playFieldInitial =
        {
            {'7','8','9'},
            {'4','5','6'},
            {'1','2','3'}
        };

            playField = playFieldInitial;
            SetField();
            turns = 0;
        }

        static void SetField()
        {
            Console.Clear();
            Console.WriteLine($"| {playField[0,0]} | {playField[0,1]} | {playField[0,2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {playField[1,0]} | {playField[1,1]} | {playField[1,2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {playField[2,0]} | {playField[2,1]} | {playField[2,2]} |");
            turns++;
        }

        public static void EnterXorO(int player, int input)
        {
            //decides next player and inputs the next "X" or "O"
            char playerSign = ' ';

            if (player == 2)
            {
                playerSign = 'O';
            }
            else if (player == 1)
            {
                playerSign = 'X';
            }

            switch (input)
            {
                case 1: playField[2, 0] = playerSign; break;
                case 2: playField[2, 1] = playerSign; break;
                case 3: playField[2, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[0, 0] = playerSign; break;
                case 8: playField[0, 1] = playerSign; break;
                case 9: playField[0, 2] = playerSign; break;

            }

        }
    }
}
