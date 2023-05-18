using System;

namespace learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();
            string test = f.GetFractionString();
            Console.WriteLine(test);
            int topValue = f.GetTop();
            Console.WriteLine(topValue);


            Fraction f1 = new Fraction(5);
            test = f1.GetFractionString();
            Console.WriteLine(test);
            topValue = f1.GetTop();
            Console.WriteLine(topValue);

            Fraction f2 = new Fraction(3, 4);
            test = f2.GetFractionString();
            Console.WriteLine(test);
            double fractionValue = f2.GetDecimalValue();
            Console.WriteLine(fractionValue);

            Fraction f3 = new Fraction(1, 3);
            test = f3.GetFractionString();
            Console.WriteLine(test);
            fractionValue = f3.GetDecimalValue();
            Console.WriteLine(fractionValue);


        }
    }
}