namespace Develop05
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal() : base()
        { }
        public SimpleGoal(string pointsPossible, string goalName, string goalDescription, string goalCompleted) : base(pointsPossible, goalName, goalDescription, goalCompleted)
        {
        }
        public override string GetGoalType()
        {
            return "SimpleGoal";
        }
    }
}