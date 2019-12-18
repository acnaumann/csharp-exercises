using System;
using System.Collections.Generic;

namespace Class2Exercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //initialize our nums list with 10 int values
            List<int> nums;nums= new List<int>() { 1, 6, 8 };

            //call SumEvenNumbers method, passing in nums list
            //Accept return value from SumEvenNumbers in to sum variable
            int sum = SumEvenNumbers(nums);
            Console.WriteLine(sum);
            
        }

        //Declare our SEN method, with a list parameter
        //SEN will return a value of type int

        public static int SumEvenNumbers(List<int> list)
        {
            int sum = 0;
            foreach (int i in list)
            //for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                    //if (List[i] % 2 == 0)
                {
                    sum += i;  
                }
            }
            return sum;



        }
    }
}
