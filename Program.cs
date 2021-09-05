using System;

namespace NUnitTestingPrograms
{
    class Program
    {
        public static void fewestCurrencyNotes(int amount)
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            Console.WriteLine("Minimum Notes to be returned by the Vending Machine as a Change->");
            int totalCurrencyCount = 0;
            for (int i = 0; i < 8; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                    totalCurrencyCount += noteCounter[i];
                }
            }
            Console.WriteLine("Minimum Num of Currency Notes returned by Vending Machine -> " + totalCurrencyCount);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");
            Console.WriteLine("Enter total amount ");
            int amount = Convert.ToInt32(Console.ReadLine());
            fewestCurrencyNotes(amount);
        }
    }
}
