namespace FinalProject
{
    public class Game
    {
        private Stats _stats = new Stats();

        public virtual void DisplayInstructions()
        {

        }
        public Stats GetStats()
        {
            return _stats;
        }
        public void BeginNewGame(Game game, string gameType)
        {
            Console.Clear();
            game.DisplayInstructions();
            game.RunGame(gameType);
            if (gameType == "single player" || gameType == "multi player game")
            {
                if (game.GetGameOutcome())
                {
                    _stats.AddTicTacToeWin();
                }
                else
                {
                    _stats.AddTicTacToeLoss();
                }
            }
            else
            {
                if (game.GetGameOutcome())
                {
                    _stats.AddGuessingGameWin();
                }
                else
                {
                    _stats.AddGuessingGameLoss();
                }
            }

        }
        public virtual bool GetGameOutcome()
        {
            return false;
        }
        public virtual void RunGame(string gameType)
        {

        }
        public void DisplayEndGameMessage(bool gameWon)
        {
            if (gameWon)
            {
                Console.WriteLine("Congradulations! You have won!!!");
            }
            else
            {
                Console.WriteLine("How unfortunate. You have lost.");
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}