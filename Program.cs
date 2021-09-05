using System;

namespace NUnitTestingPrograms
{
    class Program
    {
        static double squareRoot(int c)
        {
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");

            Console.WriteLine("Enter a Non-Negative number ");
            int c = Convert.ToInt32(Console.ReadLine());

            double toGetSquareRoot = squareRoot(c);
            Console.WriteLine("Square root of a non-negative number using Newton's method is: " + toGetSquareRoot);
        }
    }
}