namespace Develop05
{
    public class File
    {

        public void Save(List<Goal> goals, string FileName)
        {
            using (StreamWriter outputFile = new StreamWriter(FileName))
            {
                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}|{goal.GetPointsPossible()}|{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetCompletionStatus()}|{goal.GetCompletionsAchieved()}|{goal.GetBonusPointsPossible()}|{goal.GetCompletionsNeeded()}");
                }
            }
        }
        // pointsPossible, goalName, goalDescription, goalCompleted, completionsAchieved) : base(pointsPossible, goalName, goalDescription, goalCompleted)

        public List<Goal> Load(string FileName)
        {
            List<Goal> goals = new List<Goal>();
            string[] lines = System.IO.File.ReadAllLines(FileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Goal goal;
                if (parts[0] == "SimpleGoal")
                {
                    goal = new SimpleGoal(parts[1], parts[2], parts[3], parts[4]);
                }
                else if (parts[0] == "EternalGoal")
                {
                    goal = new EternalGoal(parts[1], parts[2], parts[3], parts[4], parts[5]);
                }
                else// (parts[0] == "ChecklistGoal")
                {
                    goal = new ChecklistGoal(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
                }
                goals.Add(goal);
            }
            return goals;
        }
    }
}