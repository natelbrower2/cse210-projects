using System;

namespace develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            string response = "";
            string reference = "";
            string verse = "";
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. John 3:16");
            Console.WriteLine("3. Alma 7:11");
            Console.WriteLine("4. Custom Scripture");
            Console.WriteLine("Please type the number next to the scripture that you would like to memorize: ");
            response = Console.ReadLine();
            if (response == "1")
            {
                reference = "Proverbs 3:5-6";
                verse = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
            }
            else if (response == "2")
            {
                reference = "John 3:16";
                verse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            }
            else if (response == "3")
            {
                reference = "Alma 7:11";
                verse = "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.";
            }
            else
            {
                Console.WriteLine("Please type the reference of the scripture you would like to memorize: ");
                reference = Console.ReadLine();
                Console.WriteLine("Please type this verse into the console: ");
                verse = Console.ReadLine();
            }
            response = "";
            Scripture scripture = new Scripture(reference, verse);
            while (run)
            {
                Console.Clear();
                Console.Write(scripture.displayReference() + " ");
                Console.WriteLine(scripture.getRenderedText() + "\n");
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                response = Console.ReadLine();
                if (response == "quit" || scripture.endConditionsMet())
                {
                    run = false;
                }
                else
                {
                    scripture.HideRandomWords(3);
                }
            }




            // string verse;

            // Scripture testing = new Scripture("For God so loved the world");
            // verse = testing.getRenderedText();
            // Console.WriteLine(verse);
            // Console.ReadLine();
            // testing.HideRandomWords(6);
            // verse = testing.getRenderedText();
            // Console.WriteLine(verse);

            // }

        }
    }
}