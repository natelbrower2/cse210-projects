using System;

namespace FinalProject
{

    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            string input;
            Game game = new Game();
            while (run)
            {
                Console.Clear();
                Stats stats = game.GetStats();
                Console.WriteLine($"Win percentage = {stats.GetWinPercentage()}%\n");
                Console.WriteLine("Main Menue Options:\n");
                Console.WriteLine("  1. Tic-Tac-Toe\n  2. GuessingGame\n  3. View Session Stats\n  4. Quit");
                Console.Write("Select a choice from the menue: ");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("There are 2 ways to play:\n  1. Single Player\n  2. Multiplayer");
                    Console.Write("Which way would you like to play? ");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        //begin single player game vs. the computer.
                        game.BeginNewGame(new TicTacToe(), "single player");

                    }
                    else
                    {
                        //begin multiplayer game both on the same console
                        game.BeginNewGame(new TicTacToe(), "multi player game");
                    }
                }
                else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("There are 2 ways to play:\n  1. Easy\n  2. Hard");
                    Console.Write("Which level of difficulty would you like? ");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        game.BeginNewGame(new GuessingGame(), "easy");
                    }
                    else
                    {
                        game.BeginNewGame(new GuessingGame(), "hard");
                    }
                }
                else if (input == "3")
                {
                    stats.DisplayAllStats();
                }
                else
                {
                    run = false;
                }
            }
        }
    }
}