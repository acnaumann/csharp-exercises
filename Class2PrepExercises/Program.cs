using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2PrepExercises
{
    class MainClass
    {
        /*
         *
         * Question 1:
         * 
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4, 5, 7, 8, 10, 14, 15, 18 };

            

            Console.WriteLine(Sum(numbers));
        }

        public static int Sum(List<int> numbers)
        {
            int sum;
            sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum; 
        }

    */



        //Question 2:

        //public static void Main(string[] args)
        //{
        //    List<string> words = new List<string> { "hello", "Alysson", "World", "Seevers", "Again" };

        //    foreach (string word in Five(words))
        //    {
        //        Console.WriteLine(word);
        //    }


        //}

        //public static List<string> Five(List<string> words)
        //{
        //    List<string> fiveLetters = new List<string>();

        //    foreach (string word in words)
        //    {
        //        if (word.Length == 5)
        //        {
        //            fiveLetters.Add(word);
        //        }

        //    }

        //    return fiveLetters;
        //}





        //Question 3:

        //public static void Main(string[] args)
        //{
        //    //create and initialize an array with the following values:
        //    //1,1,2,3,5,8

        //    int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };

        //    //loop through the array and print out each value

        //    foreach (int value in numbers)
        //    {
        //        Console.WriteLine(value);
        //    }
        //}

        //Question 4:

        //public static void Main(string[] args)
        //{
        //    //create gradebook dictionary where StudentId is Key and
        //    //studentName is Value

        //    Dictionary<int, string> students = new Dictionary<int, string>();
        //    string newStudent;
        //    int newId = 0;

        //    Console.WriteLine("Enter student name (or ENTER to finish): ");

        //    do
        //    {
        //        newStudent = Console.ReadLine();
        //        if (newStudent != "")
        //        {
        //            students.Add(newId, newStudent);
        //            newId += 1;
        //        }
        //    }
        //    while (newStudent != "");

        //    Console.WriteLine("class roster: ");
        //    foreach (KeyValuePair<int, string> kvp in students)
        //    {
        //        Console.WriteLine(kvp.Key + " : " + kvp.Value);
        //    }

        //    Console.ReadLine();

        //}





        //Question 5:
        //
        //public static void Main(string[] args)
        //{
        //    //create gradebook dictionary where StudentId is Key and
        //    //studentName is Value

        //    Dictionary<int, string> students = new Dictionary<int, string>();
        //    string newStudent;
        //    int newId = 0;

        //    Console.WriteLine("Enter student name (or ENTER to finish): ");

        //    do
        //    {
        //        newStudent = Console.ReadLine();
        //        if (newStudent != "")
        //        {
        //            students.Add(newId, newStudent);
        //            newId += 1;
        //        }
        //    }
        //    while (newStudent != "");

        //    StringBuilder roster = new StringBuilder("Class roster: \n");
        //    foreach (KeyValuePair<int, string> kvp in students)
        //    {

        //        roster.Append(kvp.Key + " : " + kvp.Value + "\n");
        //    }

        //    Console.WriteLine(roster);

        //}

    }
}
