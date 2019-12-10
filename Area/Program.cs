using System;

namespace Area
{
    class AreaWhile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            //string input = Console.ReadLine();
            //float radius = float.Parse(input);
            //float area = (float)3.14 * radius * radius;
            
            if (radius < 0)
            {
                Console.WriteLine("This is not a valid radius");
                Console.ReadLine();
            }
            else
            {
                double area = (float)(Math.PI * (Math.Pow(radius, 2)));
                Console.WriteLine("The area of your circle is: " + area);
            }


        }
    }
}
