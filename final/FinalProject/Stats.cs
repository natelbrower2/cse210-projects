namespace FinalProject
{
    public class Stats
    // The purpose of stats is to keep track of how many wins and lossses the player has had.
    {
        private int _ticTacToeWins;
        private int _guessingGameWins;
        private int _ticTacToeLosses;
        private int _guessingGameLosses;

        public void DisplayAllStats()
        {
            Console.Clear();
            Console.WriteLine($"Total win percentage = {GetWinPercentage()}%");
            Console.WriteLine($"Tic-Tac-Toe wins: {GetTicTacToeWins()}");
            Console.WriteLine($"Tic-Tac-Toe losses: {GetTicTacToeLosses()}");
            Console.WriteLine($"Guessing Game wins: {GetGuessingGameWins()}");
            Console.WriteLine($"Guessing Game losses: {GetGuessingGameLosses()}\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public int GetWinPercentage()
        {
            if ((_ticTacToeWins + _guessingGameWins + _ticTacToeLosses + _guessingGameLosses) == 0)
            {
                return 0;
            }
            else
            {
                return 100 * (_ticTacToeWins + _guessingGameWins) / (_ticTacToeWins + _guessingGameWins + _ticTacToeLosses + _guessingGameLosses);
            }
        }
        public int GetTicTacToeWins()
        {
            return _ticTacToeWins;
        }
        public int GetTicTacToeLosses()
        {
            return _ticTacToeLosses;
        }
        public int GetGuessingGameWins()
        {
            return _guessingGameWins;
        }
        public int GetGuessingGameLosses()
        {
            return _guessingGameLosses;
        }

        public void AddTicTacToeWin()
        {
            _ticTacToeWins += 1;
        }
        public void AddGuessingGameWin()
        {
            _guessingGameWins += 1;
        }
        public void AddTicTacToeLoss()
        {
            _ticTacToeLosses += 1;
        }
        public void AddGuessingGameLoss()
        {
            _guessingGameLosses += 1;
        }
    }
}