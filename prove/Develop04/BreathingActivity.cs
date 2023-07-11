namespace develop04
{
    public class BreathingActivity : Activity
    {
        private string _BreathIn = "Breath in...";
        private string _BreathOut = "Now breath out...";
        public void runBreathingActivity()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_activityDuration);
            while (DateTime.Now < endTime)
            {
                displayBreathInMessage();
                countdownTimer(5);
                Console.WriteLine();
                displayBreathOutMessage();
                countdownTimer(5);
                Console.WriteLine("\n");
            }
        }
        public void displayBreathInMessage()
        {
            Console.Write(_BreathIn);
        }
        public void displayBreathOutMessage()
        {
            Console.Write(_BreathOut);
        }
    }
}