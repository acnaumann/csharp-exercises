using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string Alice = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Enter a phrase to check: ");

            string input = Console.ReadLine();

            

            if (Alice.Contains(input))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            //Console.WriteLine(first_sentence);
            Console.ReadLine();

        }
    }
}
