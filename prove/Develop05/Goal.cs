namespace Develop05
{
    public class Goal
    {
        protected int _pointsPossible;
        protected string _goalName;
        protected string _goalDescription;
        protected bool _goalCompleted = false;

        public Goal()
        {
            Console.Write("What is the name of your goal? ");
            _goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            _goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            _pointsPossible = int.Parse(Console.ReadLine());
        }

        public Goal(string pointsPossible, string goalName, string goalDescription, string goalCompleted)
        {
            _pointsPossible = int.Parse(pointsPossible);
            _goalName = goalName;
            _goalDescription = goalDescription;
            _goalCompleted = bool.Parse(goalCompleted);
        }
        public virtual string GetGoalType()
        {
            return "";
        }
        public virtual int GetPointsPossible()
        {
            return _pointsPossible;
        }

        public virtual string GetGoalName()
        {
            return _goalName;
        }

        public virtual string GetGoalDescription()
        {
            return _goalDescription;
        }
        public bool GetCompletionStatus()
        {
            return _goalCompleted;
        }
        public virtual string GetCompletionsAchieved()
        {
            return "";
        }
        public virtual int AddUpPoints()
        {
            if (_goalCompleted)
            {
                return _pointsPossible;
            }
            else
            {
                return 0;
            }
        }
        public virtual void SetGoalToCompleted()
        {
            _goalCompleted = true;
        }

        public virtual void ListGoal(int counter, string checkmark)
        {
            Console.WriteLine($"{counter}. [{checkmark}] {_goalName} ({_goalDescription})");
        }
        public virtual string GetBonusPointsPossible()
        {
            return "";
        }
        public virtual string GetCompletionsNeeded()
        {
            return "";
        }
    }
}