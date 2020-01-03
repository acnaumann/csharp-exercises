using System;
using System.Linq;
using System.Text;

namespace WorkingWithStrings2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";   //@ tells C# that you
            //want to use the backslash character.
            //string myString = String.Format("{0} = {1}", "First", "Second");

            //string myString = string.Format("{0:C}", 123.45); //zero says I want to use the
            //infformation presented as a parameter but that I want it written in the
            //currency format(C).

            //string myString = string.Format("{0:N}", 1234567890);

            //string myString = string.Format("Percentage: {0:P}", .123);

            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);
            //if you add extra digits on the end it will be added to the front (to the left)

            //string myString = " That summer we took threes across the board ";

            //myString = myString.Substring(6);
            //start at the pos 6 and give that and everything after (truncates off
            //the first 5 char.

            //myString = myString.Substring(6, 14);
            ////returns char in pos. 6-14

            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");

            //myString = myString.Remove(6, 14);

            //myString = String.Format("Length before: {0} -- Length after: {1}",
            //myString.Length,
            //myString.Trim().Length);



            /*
            //string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            //immutable data type - 20:00 Bob Tabor
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            //more effective way of work with strings in a more efficent manner

           

            




            Console.WriteLine(myString);
            Console.WriteLine();




            //Console.WriteLine("Hello World!");
        }
    }
}
