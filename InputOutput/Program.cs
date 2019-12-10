using System;

namespace InputOutput
{
    class Project
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Hello " + input + "!");
        }
    }
}
