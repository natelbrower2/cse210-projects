using System;

namespace learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment("Samuel bennett", "Multiplication");
            Console.WriteLine(assignment.GetSummary());
            MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
            Console.WriteLine(math.GetHomeworkList());
            WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
            Console.WriteLine(writing.GetWritingInformation());
        }
    }
}