using System;

namespace QGamesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SumCalculator calculator = new SumCalculator();

            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int sum = calculator.SumFormula(number);
            Console.WriteLine($"The sum of the first {number} natural numbers is: {sum}");
        }
    }

    class SumCalculator
    {
        /**
         * The function f(n) = n + f(n-1) is a recursive function.
         * It can be calculated using a recursive approach , iterative approach and mathematical
         * formula based approach.
         * Explanation of my choice is written in detail in the following link shared below
         * https://roasted-ring-4d6.notion.site/Q-Games-Programmer-Test-3819e1ac94104806b4203701ee290a5d?pvs=4
         */
        public int SumFormula(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
