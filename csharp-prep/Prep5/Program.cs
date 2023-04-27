using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqr = SquareNumber(number);

        DisplayResult(name, sqr);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        string name = "n/a";
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        string number = "0";
        Console.Write("Please enter your favorite number: ");
        number = Console.ReadLine();
        int rValue = int.Parse(number);
        return rValue;
    }

    static int SquareNumber(int number)
    {
        int rValue = number * number;
        return rValue;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}
