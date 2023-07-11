using System;
// https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
namespace develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity activity = new Activity();
            BreathingActivity breathing = new BreathingActivity();
            ReflectingActivity reflecting = new ReflectingActivity();
            ListeningActivity listening = new ListeningActivity();
            // activity.showSpinner(10);
            // Console.WriteLine("Done");
            // activity.countdownTimer(10);
            // Console.WriteLine("Done");

            // activity.setActivityDescription("This is testing the activity!");
            // activity.setActivityName("This is the name");
            // activity.beginActivity();

            Console.Clear();
            bool run = true;
            string choice;

            while (run)
            {
                Console.Clear();
                Console.WriteLine("Main Options:");
                Console.WriteLine(" 1. Start breathing activity");
                Console.WriteLine(" 2. Start reflection activity");
                Console.WriteLine(" 3. Start listening activity");
                Console.WriteLine(" 4. Quit");
                Console.WriteLine("Select a choice from the menue: ");
                choice = Console.ReadLine();
                Console.Clear();

                if (choice == "1")
                {
                    breathing.setActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.setActivityName("Breathing Activity");
                    breathing.beginActivity();
                    breathing.runBreathingActivity();
                    breathing.displayEndMessage();
                }
                else if (choice == "2")
                {
                    reflecting.setActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.setActivityName("Reflection Activity");
                    reflecting.beginActivity();
                    reflecting.runReflectionActivity();
                    reflecting.displayEndMessage();
                }
                else if (choice == "3")
                {
                    listening.setActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listening.setActivityName("Listening Activity");
                    listening.beginActivity();
                    listening.runListeningActivity();
                    listening.displayEndMessage();
                }
                else
                {
                    run = false;
                }
            }

        }
    }
}