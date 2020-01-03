using System;

namespace DanExample
{
    class Person
    {
        public string Name;
        public string HairColor;
        public int Age;


        Person(string tName, string tHairColor, int tAge)
        {
            Name = tName;
            HairColor = tHairColor;
            Age = tAge;
        }

        







        public static void Main(string[] args)
        {
            Person alysson = new Person("Alysson Seevers", "Brown", 34);
            string x = alysson.Name;
            Console.WriteLine(x);
        
        }
    }
}
