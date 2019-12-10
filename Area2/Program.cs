using System;

namespace Area
{
	class AreaWhile
	{
		public static void Main(string[] args)
		{
			bool correct = false;
            while (!correct)
			{
				Console.WriteLine("Enter the radius of your circle: ");

				double radius = double.Parse(Console.ReadLine());

                if (radius > 0)
				{
					double area = (float)(Math.PI * (Math.Pow(radius, 2)));
					Console.WriteLine("The area of the circle is " + area);
					correct = true;
				}
				else
				{
					Console.WriteLine("User input is invalid");
					correct = false;
				}

			}

			//double radius = 0;
                
			//do
			//{
			//	Console.WriteLine("Enter a radius: ");
			//	radius = double.Parse(Console.ReadLine());
			//	//string input = Console.ReadLine();
			//	//float radius = float.Parse(input);
			//	//float area = (float)3.14 * radius * radius;
				
			//} while(radius < 0);
			//double area = (float)(Math.PI * (Math.Pow(radius, 2)));
			//Console.WriteLine("The area of your circle is: " + area);
		

		}
	}
}