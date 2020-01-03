using System;

namespace Scratch
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i+=2)
            //{


            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //for (int i = 25; i >= 0; i --)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int[] x = { 1, 1, 2, 3, 5, 8, 13, 21 };

            //foreach (int i in x)
            //{
            //    Console.WriteLine(i);
            //}

            string msg = "Hello World!";

            foreach (char c in msg)
            {
                

                if (Char.IsLetter(c))
                {
                    Console.WriteLine(c);
                }
                
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
