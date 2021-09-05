using System;

namespace NUnitTestingPrograms
{
    class Program
    {
        public static double celsiusToFahrenheit(double celsiusTemp)
        {
            double inFahrenheit = (celsiusTemp * 9 / 5) + 32;
            return inFahrenheit;
        }
        public static double fahrenheitToCelsius(double fahrenheitTemp)
        {
            double inCelsius = (fahrenheitTemp - 32) * 5 / 9;
            return inCelsius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");

            Console.WriteLine("Enter temp in Celsius ");
            double celsiusTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter temp in Fahrenheit ");
            double fahrenheitTemp = Convert.ToInt32(Console.ReadLine());
            
            double fahrenheit = celsiusToFahrenheit(celsiusTemp);
            double celsius = fahrenheitToCelsius(fahrenheitTemp);
            Console.WriteLine("convert the temp from celsius to fahrenheit is " + fahrenheit + "°F");
            Console.WriteLine("convert the temp from fahrenheit to celsius is " + celsius + "°C");
        }
    }
}