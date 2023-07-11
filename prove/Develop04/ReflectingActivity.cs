namespace develop04
{
    public class ReflectingActivity : Activity
    {
        private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
        private string[] _followUpQuestions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
        private List<int> _usedQuestions = new List<int>();

        public void runReflectionActivity()
        {
            displayInitialPrompt();
            displayFollowUpQuestions();
        }
        public void displayInitialPrompt()
        {
            Console.WriteLine("Consider the following prompt:\n");
            var random = new Random();
            int num = random.Next(0, _prompts.Count());
            string prompt = _prompts[num];
            Console.WriteLine($"{prompt}\n");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
            countdownTimer(5);
        }
        public void displayFollowUpQuestions()
        {
            var random = new Random();
            int num = -1;
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_activityDuration);
            string question;
            bool donePicking;
            _usedQuestions.Clear();
            while (DateTime.Now < endTime)
            {
                donePicking = false;
                //reset the used questions list if all questions have been used.
                if (_usedQuestions.Count() == _followUpQuestions.Count())
                {
                    _usedQuestions.Clear();
                }
                //make sure that the prompt hasn't been used before.
                while (!(donePicking))
                {
                    num = random.Next(0, _followUpQuestions.Count());
                    donePicking = true;
                    if (_usedQuestions.Contains(num))
                    {
                        donePicking = false;
                    }
                }
                _usedQuestions.Add(num);
                question = _followUpQuestions[num];
                Console.Write($"> {question} ");
                displaySpinner(5);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}