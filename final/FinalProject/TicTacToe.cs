namespace FinalProject
{
    public class TicTacToe : Game
    {
        private bool _gameWon;
        private Computer _computer = new Computer();

        public override void DisplayInstructions()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("When the game begins, you will be prompted with a key to help you know which gridspace corresponds to which input number. Simply type the number that corresponds with the space that you would like to go in.");
            Console.WriteLine("\nPress enter to begin");
            Console.ReadLine();
        }
        public override bool GetGameOutcome()
        {
            return _gameWon;
        }
        public void RunSinglePlayerGame()
        {
            bool run = true;
            string input;
            bool playersTurn = true;
            bool spotNotAvailable = true;
            Board board = new Board();
            Console.Clear();
            board.DrawBoard();
            while (run)
            {
                spotNotAvailable = true;
                if (playersTurn)
                {
                    while (spotNotAvailable)
                    {
                        Console.Write("Your turn:\nWhere would you like to go next? ");
                        input = Console.ReadLine();
                        if (board.SpotAvailable(int.Parse(input)))
                        {
                            board.AddSymbol("X", int.Parse(input));
                            spotNotAvailable = false;
                        }
                        else
                        {
                            Console.WriteLine("That spot is not available. Please pick a different spot.");
                        }
                    }
                    playersTurn = false;
                }
                else
                {
                    _computer.UpdateSymbols(board.GetSymbols());
                    board.AddSymbol("O", _computer.PickSquare());
                    playersTurn = true;
                }
                Console.Clear();
                board.DrawBoard();
                run = !(board.CheckGameFinished());
            }
            DisplayEndGameMessage(board.CheckGameWon("X"));
            _gameWon = board.CheckGameWon("X");
        }
        public void RunMultiPlayerGame()
        {
            bool run = true;
            string input;
            bool playersTurn = true;
            bool spotNotAvailable = true;
            Board board = new Board();
            Console.Clear();
            board.DrawBoard();
            while (run)
            {
                spotNotAvailable = true;
                if (playersTurn)
                {
                    while (spotNotAvailable)
                    {
                        Console.Write("Player 1 Turn:\nWhere would you like to go next? ");
                        input = Console.ReadLine();
                        if (board.SpotAvailable(int.Parse(input)))
                        {
                            board.AddSymbol("X", int.Parse(input));
                            spotNotAvailable = false;
                        }
                        else
                        {
                            Console.WriteLine("That spot is not available. Please pick a different spot.");
                        }
                    }
                    playersTurn = false;
                }
                else
                {
                    while (spotNotAvailable)
                    {
                        Console.Write("Player 2 Turn:\nWhere would you like to go next? ");
                        input = Console.ReadLine();
                        if (board.SpotAvailable(int.Parse(input)))
                        {
                            board.AddSymbol("O", int.Parse(input));
                            spotNotAvailable = false;
                        }
                        else
                        {
                            Console.WriteLine("That spot is not available. Please pick a different spot.");
                        }
                    }
                    playersTurn = true;
                }
                Console.Clear();
                board.DrawBoard();
                run = !(board.CheckGameFinished());
            }
            DisplayEndGameMessage(board.CheckGameWon("X"));
            _gameWon = board.CheckGameWon("X");
        }


        public override void RunGame(string gameType)
        {
            if (gameType == "single player")
            {
                RunSinglePlayerGame();
            }
            else if (gameType == "multi player game")
            {
                RunMultiPlayerGame();
            }
        }

    }
}