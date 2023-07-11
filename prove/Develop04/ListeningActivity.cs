namespace develop04
{
    public class ListeningActivity : Activity
    {
        string[] _prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
        List<string> _responses = new List<string>();

        public void runListeningActivity()
        {
            displayRandomPrompt();
            getResponses();
            int numResponses = countResponses();
            Console.WriteLine($"You listed {numResponses} items!");
        }

        public int countResponses()
        {
            int numResponses = _responses.Count();
            return numResponses;
        }

        public void displayRandomPrompt()
        {
            var random = new Random();
            int num = random.Next(0, _prompts.Count());
            string prompt = _prompts[num];
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"---{prompt}---");
            Console.Write("You May begin in: ");
            countdownTimer(5);
            Console.WriteLine();
        }
        public void getResponses()
        {
            string response;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_activityDuration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                response = Console.ReadLine();
                _responses.Add(response);
            }
        }
    }
}