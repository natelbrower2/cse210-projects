namespace develop04
{
    public class Activity
    {
        protected int _activityDuration = 0;
        private string _activityName = "";
        private string _activityDescription = "";

        public void beginActivity()
        {
            displayStartingMessage();
            getDurationOfActivity();
            Console.Clear();
            // Tell the user to prepare to begin
            Console.WriteLine("\nGet ready...");
            displaySpinner(5);
            Console.WriteLine();
        }
        public void setActivityDescription(string description)
        {
            _activityDescription = description;
        }

        public void setActivityName(string name)
        {
            _activityName = name;
        }

        public void displayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {this._activityName}.\n");
            Console.WriteLine(_activityDescription);
        }

        public void getDurationOfActivity()
        {
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            string response = Console.ReadLine();
            _activityDuration = int.Parse(response);
        }

        public void displayEndMessage()
        {
            Console.WriteLine("Well done!!");
            displaySpinner(5);
            Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName}.");
            displaySpinner(5);
        }
        public void displaySpinner(int seconds)
        {
            string[] anamation = { "|", "/", "-", "\\" };
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write(anamation[i]);
                Thread.Sleep(500);
                Console.Write("\b \b");
                i++;
                if (i >= 4)
                {
                    i = 0;
                }
            }
        }

        public void countdownTimer(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                if (i >= 10)
                {
                    Console.Write("\b\b  \b\b");
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
        }

    }
}