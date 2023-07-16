namespace FinalProject
{
    public class GuessingGame : Game
    {
        // private List<Guess> _guesses = new List<Guess>();
        private Word word = new Word();
        private Guesses guesses = new Guesses();
        private bool _gameWon;
        public override void DisplayInstructions()
        {
            Console.WriteLine("Welcome to the guessing game!\n");
            Console.WriteLine("The point of this game is to guess the word that the commputer has chosen. The commputer will give you hints to help you guess the word. The hints are as follows:");
            Console.WriteLine("  1. A capitalized letter means that you have guessed a correct letter and it is in the correct spot.");
            Console.WriteLine("  2. A lowercase letter means that you have guessed a correct letter but it's in the wrong spot.");
            Console.WriteLine("  3. Finally, an underscore (_) indicates that you have not guessed the correct letter.");
            Console.WriteLine("Guess the word before you run out of guesses in order to win the game.\n");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
        }
        public override bool GetGameOutcome()
        {
            return _gameWon;
        }

        public override void RunGame(string gameType)
        {
            bool run = true;
            int guessesAllowed;
            string input = "";
            if (gameType == "hard")
            {
                guessesAllowed = 8;
            }
            else
            {
                guessesAllowed = 12;
            }
            while (run)
            {
                Console.Clear();
                Console.WriteLine($"You have {guessesAllowed - guesses.GetNumberOfGuesses()} guesses left.");
                guesses.DisplayPreviousGuesses();
                Console.WriteLine("\nHint:");
                if (input == "")
                {
                    Console.WriteLine(word.GetOriginalHint());
                }
                else
                {
                    Console.WriteLine(word.GetHint(input));
                }
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guesses.AddGuess(input);
                if (word.guessedCorrectly(input))
                {
                    run = false;
                    _gameWon = true;
                    DisplayEndGameMessage(true);
                }
                if (guessesAllowed == guesses.GetNumberOfGuesses())
                {
                    run = false;
                    _gameWon = false;
                    Console.WriteLine($"\nThe word was {word.GetWord()}\n");
                    DisplayEndGameMessage(false);
                }
            }
        }
    }
}