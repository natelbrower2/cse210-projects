namespace FinalProject
{
    public class Guesses
    {
        List<string> _guesses = new List<string>();

        public List<string> GetGuesses()
        {
            return _guesses;
        }
        public void AddGuess(string guess)
        {
            _guesses.Add(guess);
        }
        public int GetNumberOfGuesses()
        {
            return _guesses.Count();
        }
        public void DisplayPreviousGuesses()
        {
            Console.WriteLine("Previous Guesses:");
            foreach (string guess in _guesses)
            {
                Console.WriteLine(guess);
            }
        }
    }
}