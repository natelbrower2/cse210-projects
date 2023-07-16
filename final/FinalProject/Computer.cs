namespace FinalProject
{
    public class Computer
    {
        private string[] _symbols;

        public void UpdateSymbols(string[] symbols)
        {
            _symbols = symbols;
        }
        public int PickSquare()
        {
            int rValue = -1;
            Console.Write("Computer's turn: ");
            DisplaySpinner(2);

            //check to see if there is a possible win in the next move
            for (int i = 0; i <= 8; i++)
            {
                if (_symbols[i] == " ")
                {
                    _symbols[i] = "O"; // check each empty spot to see if putting an O will result in a win.
                    if (CheckGameWon("O"))
                    {
                        rValue = i; //pick the winning spot
                    }
                    _symbols[i] = " "; // put a space back into the spot that was tested
                }
            }

            if (rValue == -1) // try to block the player from winning
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (_symbols[i] == " ")
                    {
                        _symbols[i] = "X"; // check each empty spot to see if the player could win on their next turn.
                        if (CheckGameWon("X"))
                        {
                            rValue = i; //block the player
                        }
                        _symbols[i] = " "; // put a space back into the spot that was tested
                    }
                }
            }

            if (rValue == -1) // if the computer can't win or block, pick a random square.
            {
                var random = new Random();
                bool spotNotAvailable = true;
                while (spotNotAvailable)
                {
                    int num = random.Next(0, 8);
                    if (_symbols[num] == " ")
                    {
                        spotNotAvailable = false;
                        rValue = num;
                    }
                }
            }
            return rValue + 1;
        }


        private bool CheckGameWon(string symbol)
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
        public void DisplaySpinner(int seconds)
        {
            string[] anamation = { "|", "/", "-", "\\" };
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write(anamation[i]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i++;
                if (i >= 4)
                {
                    i = 0;
                }
            }
        }
    }
}