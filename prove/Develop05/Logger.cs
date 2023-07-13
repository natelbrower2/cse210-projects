namespace Develop05
{
    public class Logger
    // The purpose of logger is to hold goals
    {
        private List<Goal> _goals = new List<Goal>();

        public void StoreGoal(Goal goal)
        {
            _goals.Add(goal);
        }
        public void MarkGoalDone(int index)
        {
            _goals[index - 1].SetGoalToCompleted();
        }
        public void ListGoalNames()
        {
            int counter = 1;
            Console.WriteLine("The goals are: ");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{counter}. {goal.GetGoalName()}");
                counter += 1;
            }
        }
        public void ListGoals()
        {
            int counter = 1;
            string checkmark;
            Console.WriteLine("The goals are: ");
            foreach (Goal goal in _goals)
            {
                checkmark = " ";
                if (goal.GetCompletionStatus())
                {
                    checkmark = "X";
                }
                goal.ListGoal(counter, checkmark);
                counter += 1;
            }
        }
        public int CalculatePoints()
        {
            int points = 0;
            foreach (Goal goal in _goals)
            {
                points += goal.AddUpPoints();
            }
            return points;
        }
        public void DownloadGoals(List<Goal> goals)
        {
            _goals = goals;
        }
        public List<Goal> GetGoals()
        {
            return _goals;
        }
    }
}