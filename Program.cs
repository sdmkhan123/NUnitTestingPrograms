using System;

namespace NUnitTestingPrograms
{
    class Program
    {
        static double monthlyPayment(double P, double R, double Y)
        {
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / (1 - (1 / (Math.Pow(1 + r, n))));
            return payment;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");

            Console.WriteLine("Enter Principal amount ");
            double P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate Percent per year ");
            double R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of years ");
            double Y = Convert.ToInt32(Console.ReadLine());

            double monthlyGetPayment = monthlyPayment(P, R, Y);
            Console.WriteLine("The monthly Payment is " + monthlyGetPayment);
        }
    }
}