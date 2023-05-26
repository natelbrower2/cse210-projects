using System;

namespace develop03
{
    //The purpose of Word is to keep track of a word along with the hidden version of the word. It also keeps track of whether or not the word is hidden.
    public class Word
    {
        private string _word;
        private string _hiddenWord = "";
        private bool _hidden;

        public Word(string word)
        {
            _word = word;
            _hidden = false;
            foreach (char c in _word)
            {
                _hiddenWord = _hiddenWord + "_";
            }
        }

        public void hide()
        {
            this._hidden = true;
        }

        public void show(string word)
        {
            this._hidden = false;
        }

        public bool isHidden()
        {
            return _hidden;
        }
        public string getRenderedText()
        {
            if (_hidden)
            {
                return this._hiddenWord;
            }
            else
            {
                return this._word;
            }
        }
    }
}