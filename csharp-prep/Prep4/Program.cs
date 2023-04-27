using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string input = "1";
        int number = 1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int largest = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}