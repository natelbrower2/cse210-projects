using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        string guess = "0";
        int guessInt = 0;

        Console.Write("What is the magic number? ");
        guess = Console.ReadLine();
        guessInt = int.Parse(guess);
        while (guessInt != magicNumber)
        {
            if (guessInt < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessInt > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine("Thanks for playing");
    }
}