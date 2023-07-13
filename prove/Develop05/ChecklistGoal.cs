namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        private int _bonusPointsPossible;
        private int _completionsNeeded;
        private int _completionsAchieved = 0;

        public ChecklistGoal() : base()
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            _completionsNeeded = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            _bonusPointsPossible = int.Parse(Console.ReadLine());
        }
        public ChecklistGoal(string pointsPossible, string goalName, string goalDescription, string goalCompleted, string completionsAchieved, string bonusPointsPossible, string completionsNeeded) : base(pointsPossible, goalName, goalDescription, goalCompleted)
        {
            _completionsAchieved = int.Parse(completionsAchieved);
            _bonusPointsPossible = int.Parse(bonusPointsPossible);
            _completionsNeeded = int.Parse(completionsNeeded);
        }
        public override void ListGoal(int counter, string checkmark)
        {
            Console.WriteLine($"{counter}. [{checkmark}] {_goalName} ({_goalDescription}) -- Currently completed: {_completionsAchieved}/{_completionsNeeded}");
        }
        public override void SetGoalToCompleted()
        {
            _completionsAchieved += 1;
            if (_completionsAchieved == _completionsNeeded)
            {
                _goalCompleted = true;
            }
        }
        public override int AddUpPoints()
        {
            int bonus = 0;
            if (_completionsAchieved >= _completionsNeeded)
            {
                bonus = _bonusPointsPossible;
            }
            return (_pointsPossible * _completionsAchieved) + bonus;
        }
        public override string GetGoalType()
        {
            return "ChecklistGoal";
        }
        public override string GetCompletionsAchieved()
        {
            return $"{_completionsAchieved}";
        }
        public override string GetBonusPointsPossible()
        {
            return $"{_bonusPointsPossible}";
        }
        public override string GetCompletionsNeeded()
        {
            return $"{_completionsNeeded}";
        }
    }
}