using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a height: ");
            int height = int.Parse(Console.ReadLine());

            int area = width * height;

            Console.WriteLine("The area of the rectangle is: " + area);

            Console.WriteLine("Enter the temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * (5.0 / 9.0);

            Console.WriteLine("The temperature in C is: " + (int)(celsius));

        }
    }
}
