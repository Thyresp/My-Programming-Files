using System;

namespace xo_game_oh_nor_here_we_go_again
{
    internal class Program
    {

        //making this thing static wish ı knew before
        static char[,] xoGame =
{
                {'7','8','9'},
                {'4','5','6'},
                {'1','2','3'}
            };


        static string confirmedSelection;
        private static int numberSelection;

        static void Main(string[] args)
        {
            char[] firstCase = { 'X', 'O', 'X', 'O', 'X', 'O', 'X', 'O', 'X' };
            char[] secondCase = { 'O', 'X', 'O', 'X', 'O', 'X', 'O', 'X', 'O' };

            SetField();


            
            //selects first player
            bool selectionCheck = false;

            while (selectionCheck == false)
            {


                Console.WriteLine("Please Select (X or O):");
                string firstSelection = Console.ReadLine();

                if (firstSelection == "X" || firstSelection == "O")
                {
                    Console.WriteLine($"Ok first Player is {firstSelection}");
                    selectionCheck = true;
                    confirmedSelection = firstSelection;
                    
                }
                else
                {
                    Console.WriteLine("Sorry You Didnt Choose (X or O)");

                }


            }


            //goes in order
            switch (confirmedSelection)
            {
                

                case "X":
                    for (int i = 0; i < 9; i++)
                    {
                        if (WinnerCheck() == true)
                        {
                            i = 9;
                        }
                        else
                        {
                            //selects location
                            bool anotherCheck = false;

                            while (anotherCheck == false)
                            {

                                Console.WriteLine("Please Select Location(1-9)");
                                string selection = Console.ReadLine();

                                if (Int32.TryParse(selection, out numberSelection) == false)
                                {

                                    Console.WriteLine("Sorry Not a Number");

                                }
                                else
                                {
                                    if (numberSelection <= 0 || numberSelection >= 10)
                                    {
                                        Console.WriteLine("Sorry number is Not in the range(1-9)");
                                    }
                                    else
                                    {
                                        //puts X or O in its Location
                                        switch (numberSelection)
                                        {
                                            case 1:
                                                if (xoGame[2, 0] == 'X' || xoGame[2, 0] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[2, 0] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 2:
                                                if (xoGame[2, 1] == 'X' || xoGame[2, 1] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[2, 1] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 3:
                                                if (xoGame[2, 2] == 'X' || xoGame[2, 2] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[2, 2] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 4:
                                                if (xoGame[1, 0] == 'X' || xoGame[1, 0] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[1, 0] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 5:
                                                if (xoGame[1, 1] == 'X' || xoGame[1, 1] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[1, 1] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 6:
                                                if (xoGame[1, 2] == 'X' || xoGame[1, 2] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[1, 2] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 7:
                                                if (xoGame[0, 0] == 'X' || xoGame[0, 0] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[0, 0] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 8:
                                                if (xoGame[0, 1] == 'X' || xoGame[0, 1] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[0, 1] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 9:
                                                if (xoGame[0, 2] == 'X' || xoGame[0, 2] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[0, 2] = firstCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                        }

                                        SetField();
                                    }

                                }
                            }
                        }


                        



                    }
                    break;

                case "O":
                    for (int i = 0; i < 9; i++)
                    {
                        if (WinnerCheck() == true)
                        {
                            i = 9;
                        }
                        else
                        {
                            //selects location
                            bool anotherCheck = false;

                            while (anotherCheck == false)
                            {

                                Console.WriteLine("Please Select Location(1-9)");
                                string selection = Console.ReadLine();

                                if (Int32.TryParse(selection, out numberSelection) == false)
                                {

                                    Console.WriteLine("Sorry Not a Number");

                                }
                                else
                                {
                                    if (numberSelection <= 0 || numberSelection >= 10)
                                    {
                                        Console.WriteLine("Sorry number is Not in the range(1-9)");
                                    }
                                    else
                                    {
                                        //puts X or O in its Location
                                        switch (numberSelection)
                                        {
                                            case 1:
                                                if (xoGame[2, 0] == 'X' || xoGame[2, 0] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[2, 0] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 2:
                                                if (xoGame[2, 1] == 'X' || xoGame[2, 1] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[2, 1] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 3:
                                                if (xoGame[2, 2] == 'X' || xoGame[2, 2] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[2, 2] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 4:
                                                if (xoGame[1, 0] == 'X' || xoGame[1, 0] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[1, 0] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 5:
                                                if (xoGame[1, 1] == 'X' || xoGame[1, 1] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[1, 1] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 6:
                                                if (xoGame[1, 2] == 'X' || xoGame[1, 2] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[1, 2] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 7:
                                                if (xoGame[0, 0] == 'X' || xoGame[0, 0] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[0, 0] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 8:
                                                if (xoGame[0, 1] == 'X' || xoGame[0, 1] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[0, 1] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;

                                            case 9:
                                                if (xoGame[0, 2] == 'X' || xoGame[0, 2] == 'O')
                                                {
                                                    Console.WriteLine("Sorry This Place Is Full");
                                                }
                                                else
                                                {
                                                    xoGame[0, 2] = secondCase[i];
                                                    anotherCheck = true;
                                                }
                                                break;
                                        }

                                        SetField();
                                    }

                                }
                            }
                        }


                        

                    }
                    break;


            }

        }

        public static void SetField()
        {
            //displays board
            Console.Clear();
            Console.WriteLine($"| {xoGame[0, 0]} | {xoGame[0, 1]} | {xoGame[0, 2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {xoGame[1, 0]} | {xoGame[1, 1]} | {xoGame[1, 2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {xoGame[2, 0]} | {xoGame[2, 1]} | {xoGame[2, 2]} |");
        }

        public static bool WinnerCheck()
        {
            //checks for win condition
            for (int i = 0; i < xoGame.GetLength(0); i++)
            {
                if (xoGame[i, 0] == xoGame[i, 1] && xoGame[i, 1] == xoGame[i, 2])
                {
                    Console.WriteLine($"Game Finished {xoGame[i, 0]} won!!(Horizontal)");
                    return true;
                }
                if (xoGame[0, i] == xoGame[1, i] && xoGame[1, i] == xoGame[2, i])
                {
                    Console.WriteLine($"Game Finished {xoGame[0, i]} won!!(Vertical)");
                    return true;
                }

            }

            if (xoGame[0, 0] == xoGame[1, 1] && xoGame[1, 1] == xoGame[2, 2])
            {
                Console.WriteLine($"Game Finished {xoGame[0, 0]} won!!(Diagonal)");
                return true;
            }
            else if (xoGame[2, 0] == xoGame[1, 1] && xoGame[1, 1] == xoGame[0, 2])
            {
                Console.WriteLine($"Game Finished {xoGame[2, 0]} won!!(Diagonal)");
                return true;
            }

            return false;
        }


    }
}
