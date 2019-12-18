using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharactersStudio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. " +
                "Aliquam erat volutpat. Donec sit amet suscipit metus, " +
                "non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, " +
                "volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<string, int> counts = CountingCharacters(text);



        }

        public static Dictionary<string, int> CountingCharacters(string text)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            string kvp;

            foreach (char c in text)
            {
                int count = 1;
                if (kvp.ContainsKey(c))
                {
                    count = count + 1;
                }
                else
                {
                    kvp.Add('c', count);
                }
            }

            foreach(KeyValuePair<string, int> kvp in counts)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
            


        }
    }
}


using System;
using System.Collections.Generic;
​
namespace CountingCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
​
                
            Dictionary<string, int> counts = CountCharacters(text);
        }
​
        public static Dictionary<string, int> CountCharacters(string text)
        {
            return null;
        }
    }
}
