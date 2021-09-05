using System;

namespace NUnitTestingPrograms
{
    class Program
    {
        static int toBinary(int decimalNnumber)
        {
            if (decimalNnumber == 0)
            {
                return 0;
            }
            else
            {
                return (decimalNnumber % 2 + 10 * toBinary(decimalNnumber / 2));
            }   
        }

        /* Iterative method using array 
     
        static void toBinary(int decimalNnumber)
        {
            int[] binaryNum = new int[32];
            int i = 0;
            while (decimalNnumber > 0)
            {
                binaryNum[i] = decimalNnumber % 2;
                decimalNnumber = decimalNnumber / 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
                Console.Write(binaryNum[j]);
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");

            Console.WriteLine("Enter a decimal number ");
            int decimalNnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(toBinary(decimalNnumber));
        }
    }
}