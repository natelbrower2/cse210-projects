using System;

using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            // // add some test entries (load from file)
            // Entry myEntry = new Entry();
            // myEntry.StorePrompt("What is your name?");
            // myEntry.StoreResponse("Matthew Manley");
            // myEntry.StoreDate("8 May 2023");

            // Entry yourEntry = new Entry();
            // yourEntry.StorePrompt("What is your fav food?");
            // yourEntry.StoreResponse("Peanut Butter");
            // yourEntry.StoreDate("8 May 2023");

            // // create a journal to test
            // Journal journal = new Journal();
            // journal.StoreEntry(myEntry);
            // journal.StoreEntry(yourEntry);

            // //show the journal contents
            // List<Entry> entries = journal.GetEntries();
            // foreach (Entry entry in entries)
            // {
            //     string message = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
            //     Console.WriteLine(message);
            // }

            // //save the journal
            // File filer = new File();
            // filer.Save(journal, "journal.txt");
            // Console.WriteLine("The journal has been saved");

            ///actual code for the assignment below.
            string GetPrompt()
            {
                var random = new Random();
                var prompts = new List<string> { "What was the best part of my day? ", "What was the hardes thing I accomplished today? ", "Who did I serve today? ", "When did I feel the best today? ", "How did I see the hand of the Lord in my life today? " };
                int promptIndex = random.Next(prompts.Count);
                return prompts[promptIndex];
            }

            string GetDate()
            {
                // string today = DateTime.Today.ToString();
                DateOnly today = DateOnly.FromDateTime(DateTime.Now);
                return today.ToString();
            }

            bool run = true;
            string Choice;
            string Prompt;
            string Date;
            string Response;
            Journal journal = new Journal();
            File filer = new File();
            while (run)
            {
                Console.WriteLine("Please select one of the following choices: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do? ");
                Choice = Console.ReadLine();

                if (Choice == "1")
                {
                    Date = GetDate();
                    Prompt = GetPrompt();
                    Console.WriteLine($"Date: {Date} Prompt: {Prompt}");
                    Console.Write("> ");
                    Response = Console.ReadLine();
                    Entry entry = new Entry();
                    entry.StoreDate(Date);
                    entry.StorePrompt(Prompt);
                    entry.StoreResponse(Response);
                    journal.StoreEntry(entry);
                }

                else if (Choice == "2")
                {
                    List<Entry> entries = journal.GetEntries();
                    foreach (Entry entry in entries)
                    {
                        string message = $"Date: {entry.GetDate()} Prompt: {entry.GetPrompt()} Response: {entry.GetResponse()}\n";
                        Console.WriteLine(message);
                    }
                }

                else if (Choice == "3")
                {
                    Console.WriteLine("What file would you like to load from?");
                    string FileName = Console.ReadLine();
                    List<Entry> newEntries = filer.Load(FileName);
                    foreach (Entry e in newEntries)
                    {
                        journal.StoreEntry(e);
                    }

                }

                else if (Choice == "4")
                {
                    Console.WriteLine("What file would you like to save to? ");
                    string FileName = Console.ReadLine();
                    filer.Save(journal, FileName);
                }

                else if (Choice == "5")
                {
                    run = false;
                }

                else
                {
                    Console.WriteLine("That wasn't an option.");
                }
            }
        }
    }
}