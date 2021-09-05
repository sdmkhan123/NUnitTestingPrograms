using System;

namespace NUnitTestingPrograms
{
    class Program
    {
        static int swapNibbles(int decimalNum)
        {
            return ((decimalNum & 0x0F) << 4 | (decimalNum & 0xF0) >> 4);
        }

        static bool isPowerOfTwo(int resultantNum)
        {
            if (resultantNum == 0)
                return false;

            while (resultantNum != 1)
            {
                if (resultantNum % 2 != 0)
                    return false;

                resultantNum = resultantNum / 2;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");

            Console.WriteLine("Enter a decimal number ");
            int decimalNnumber = Convert.ToInt32(Console.ReadLine());
            int resultantNum = swapNibbles(decimalNnumber);
            Console.WriteLine("After swap the nibble the resultant num is " + resultantNum);
            Console.Write("To check the resultant is the power of two or not: -> ");
            Console.WriteLine(isPowerOfTwo(resultantNum) ? "Yes" : "No");
        }
    }
}