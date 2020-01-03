using System;

namespace Strings2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str;
            string input;
            int indexInput;


            str = "Alice was beginning to get very tired of " +
                "sitting by her sister on the bank, and of having " +
                "nothing to do: once or twice she had peeped into " +
                "the book her sister was reading, but it had no " +
                "pictures or conversations in it, 'and what is the use " +
                "of a book,' thought Alice 'without pictures or " +
                "conversation?'";


            Console.WriteLine("Enter a phrase to check: ");
            input = Console.ReadLine();

            indexInput = str.IndexOf(input);
            Console.WriteLine("Was term found? " + "\n" + (indexInput >= 0));


            //Console.WriteLine(str.Contains(input));
        }
    }
}
