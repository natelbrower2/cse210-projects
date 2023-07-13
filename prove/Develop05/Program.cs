using System;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int points;
            string input;
            Logger logger = new Logger();
            File file = new File();
            Rank rank = new Rank();
            while (run)
            {
                points = logger.CalculatePoints();
                //To exceed the requirements, I made it so that the user has a rank based on how many points they have.
                //I accomplished this by making a "Rank" class.
                Console.WriteLine($"\nYou have {points} points.\nRank: {rank.GetRank(points)}\n");
                Console.WriteLine("Menue Options:");
                Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
                Console.Write("Select a choice from the menue: ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    //Create new goal
                    Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        logger.StoreGoal(new SimpleGoal());
                    }
                    else if (input == "2")
                    {
                        logger.StoreGoal(new EternalGoal());
                    }
                    else
                    {
                        logger.StoreGoal(new ChecklistGoal());
                    }
                }
                else if (input == "2")
                {
                    //List Goals
                    logger.ListGoals();
                }
                else if (input == "3")
                {
                    //Save Goals
                    Console.WriteLine("What file would you like to save to? ");
                    file.Save(logger.GetGoals(), Console.ReadLine());
                }
                else if (input == "4")
                {
                    //Load Goals
                    Console.WriteLine("What file would you like to load from? ");
                    logger.DownloadGoals(file.Load(Console.ReadLine()));
                }
                else if (input == "5")
                {
                    //Record Event
                    logger.ListGoalNames();
                    Console.Write("Which goal did you accomplish? ");
                    logger.MarkGoalDone(int.Parse(Console.ReadLine()));
                    int newPoints = logger.CalculatePoints();
                    Console.WriteLine($"Congradulations! You have earned {newPoints - points} points!");
                    rank.PromotionMessage(newPoints, points);
                    Console.WriteLine($"You now have {newPoints} points.");
                }
                else
                {
                    run = false;
                }
            }
        }
    }
}