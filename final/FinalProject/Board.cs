namespace FinalProject
{
    public class Board
    {
        private string[] _symbols = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public void DrawBoard()
        {
            Console.WriteLine("Gameboard:            Key:");
            Console.WriteLine($" {_symbols[0]} | {_symbols[1]} | {_symbols[2]}             1 | 2 | 3");
            Console.WriteLine("---|---|---           ---|---|---");
            Console.WriteLine($" {_symbols[3]} | {_symbols[4]} | {_symbols[5]}             4 | 5 | 6");
            Console.WriteLine("---|---|---           ---|---|---");
            Console.WriteLine($" {_symbols[6]} | {_symbols[7]} | {_symbols[8]}             7 | 8 | 9");
        }
        public void AddSymbol(string symbol, int placement)
        {
            _symbols[placement - 1] = symbol;
        }
        public string[] GetSymbols()
        {
            return _symbols;
        }
        public bool SpotAvailable(int position)
        {
            if (_symbols[position - 1] == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckGameFinished()
        {
            bool rValue = false;
            if (!(_symbols.Contains(" ")))
            // checks if all spots have been occupied
            {
                rValue = true;
            }
            else if (//checks to see if the same symbol is in any three spots in a row
            (((_symbols[4] == _symbols[1]) && (_symbols[4] == _symbols[7])) && !(_symbols[4] == " ")) ||
            (((_symbols[4] == _symbols[2]) && (_symbols[4] == _symbols[6])) && !(_symbols[4] == " ")) ||
            (((_symbols[4] == _symbols[5]) && (_symbols[4] == _symbols[3])) && !(_symbols[4] == " ")) ||
            (((_symbols[4] == _symbols[0]) && (_symbols[4] == _symbols[8])) && !(_symbols[4] == " ")) ||
            (((_symbols[0] == _symbols[1]) && (_symbols[0] == _symbols[2])) && !(_symbols[0] == " ")) ||
            (((_symbols[0] == _symbols[3]) && (_symbols[0] == _symbols[6])) && !(_symbols[0] == " ")) ||
            (((_symbols[8] == _symbols[2]) && (_symbols[8] == _symbols[5])) && !(_symbols[8] == " ")) ||
            (((_symbols[8] == _symbols[6]) && (_symbols[8] == _symbols[7])) && !(_symbols[8] == " ")))
            {
                rValue = true;
            }
            return rValue;
        }
        public bool CheckGameWon(string symbol)
        {
            if (//checks to see if the players symbol (X) is in any three spots in a row
            (((_symbols[4] == _symbols[1]) && (_symbols[4] == _symbols[7])) && (_symbols[4] == symbol)) ||
            (((_symbols[4] == _symbols[2]) && (_symbols[4] == _symbols[6])) && (_symbols[4] == symbol)) ||
            (((_symbols[4] == _symbols[5]) && (_symbols[4] == _symbols[3])) && (_symbols[4] == symbol)) ||
            (((_symbols[4] == _symbols[0]) && (_symbols[4] == _symbols[8])) && (_symbols[4] == symbol)) ||
            (((_symbols[0] == _symbols[1]) && (_symbols[0] == _symbols[2])) && (_symbols[0] == symbol)) ||
            (((_symbols[0] == _symbols[3]) && (_symbols[0] == _symbols[6])) && (_symbols[0] == symbol)) ||
            (((_symbols[8] == _symbols[2]) && (_symbols[8] == _symbols[5])) && (_symbols[8] == symbol)) ||
            (((_symbols[8] == _symbols[6]) && (_symbols[8] == _symbols[7])) && (_symbols[8] == symbol)))
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