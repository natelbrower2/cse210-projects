namespace Develop05
{
    public class EternalGoal : Goal
    {
        private int _completionsAchieved = 0;
        public EternalGoal() : base()
        { }
        public EternalGoal(string pointsPossible, string goalName, string goalDescription, string goalCompleted, string completionsAchieved) : base(pointsPossible, goalName, goalDescription, goalCompleted)
        {
            _completionsAchieved = int.Parse(completionsAchieved);
        }
        public override void SetGoalToCompleted()
        {
            _completionsAchieved += 1;
        }
        public override int AddUpPoints()
        {
            return _pointsPossible * _completionsAchieved;
        }
        public override string GetCompletionsAchieved()
        {
            return $"{_completionsAchieved}";
        }
        public override string GetGoalType()
        {
            return "EternalGoal";
        }
    }
}