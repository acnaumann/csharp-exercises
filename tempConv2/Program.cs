using System;

namespace tempConv2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int fahrenheit;
            int celsius;
            string input;

            Console.WriteLine("Enter a temperature in Fahrenheit: ");
            input = Console.ReadLine();
            fahrenheit = int.Parse(input);

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The temperature in Celsius is: " + celsius);
            Console.ReadLine();
        }
    }
}
