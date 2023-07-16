namespace FinalProject
{
    public class Word
    {
        string[] _words = { "cat", "dog", "pizza", "shovel" };
        string _word;
        public Word()
        {
            Random random = new Random();
            int index = random.Next(0, _words.Count());
            _word = _words[index];
        }
        public string GetWord()
        {
            return _word;
        }
        public string GetHint(string guess)
        {
            while (guess.Length < _word.Length)
            {
                guess += " ";
            }
            string rValue = "";
            List<int> usedIndxPos = new List<int>();
            for (int i = 0; i < _word.Length; i++)
            {
                if (guess[i] == _word[i])
                {
                    rValue += guess.ToUpper()[i];
                }
                else if ((_word.Contains(guess[i])) && (_word[(_word.IndexOf(guess[i]))] != guess[(_word.IndexOf(guess[i]))]) && !(usedIndxPos.Contains(_word.IndexOf(guess[i]))))
                {
                    rValue += guess.ToLower()[i];
                    usedIndxPos.Add(_word.IndexOf(guess[i]));
                }
                else
                {
                    rValue += "_";
                }
            }
            return rValue;
        }
        public string GetOriginalHint()
        {
            string rValue = "";
            for (int i = 0; i < _word.Length; i++)
            {
                rValue += "_";
            }
            return rValue;
        }
        public bool guessedCorrectly(string guess)
        {
            if (guess == _word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}