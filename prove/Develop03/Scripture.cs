using System;

namespace develop03
{
    public class Scripture
    {
        private List<Word> _words = new List<Word>();
        private string _verse;
        private Reference _reference;

        public Scripture(string reference, string verse)
        {
            string[] words = verse.Split(" ");
            foreach (string word in words)
            {
                Word newWord = new Word(word);
                _words.Add(newWord);
            }
            this._verse = verse;
            // this._reference = reference;
            _reference = new Reference(reference);
        }
        public void HideRandomWords(int numberOfWords)
        {
            var random = new Random();
            for (int i = 0; i < numberOfWords; i++)
            {
                int num = random.Next(0, _words.Count);
                if (_words[num].isHidden())
                {
                    int counter = 0;
                    while (_words[num].isHidden() & counter < _words.Count)
                    {
                        num = random.Next(0, _words.Count);
                        counter++;
                    }
                }
                _words[num].hide();
            }
        }

        public string getRenderedText()
        {
            string verse = "";
            foreach (Word word in _words)
            {
                verse += word.getRenderedText() + " ";
            }
            return verse;
        }
        public string displayReference()
        {
            return this._reference.formatTheReference();
        }
        public bool endConditionsMet()
        {
            bool rValue = true;
            foreach (Word word in _words)
            {
                if (!(word.isHidden()))
                {
                    rValue = false;
                }
            }
            return rValue;
        }
    }
}