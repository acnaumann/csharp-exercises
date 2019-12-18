using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Categories { get; set; }
        public DateTime DateAdded { get; set; }

    
        public MenuItem(string name, string description, double price, List<string> categories, DateTime added)
        {
            Name = name;
            Description = description;
            Price = price;
            Categories = categories;
            DateAdded = added;


        }

    }

    public class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(string name, List<MenuItem> items, DateTime date)
        {
            Name = name;
            Items = items;
            LastUpdated = date;


        }
    }



    class MainClass
    {
        public static void Main(string[] args)
        {
            MenuItem pasta = new MenuItem("Bolognese",
                "meatsauce",
                13.99,
                new List<string>() { "entree", "dinner" },
                new DateTime()
                );
            MenuItem tiramisu = new MenuItem("Tiramisu",
                "ladyfingers, coffee, marscapone",
                4.99,
                new List<string>() { "dessert" },
                new DateTime()
                );

            Menu resMenu = new Menu(
                "That One Place",
                new List<MenuItem>() { pasta, tiramisu },
                new DateTime()
                );

            Console.WriteLine("Restuarant Name: " + resMenu.Name);

            Console.WriteLine(tiramisu.Name + " " + tiramisu.Price);

            resMenu.Items[1].Price = 7.99;

            Console.WriteLine(resMenu.Items[1].Name + " " + resMenu.Items[1].Price);
            

        }


    }

}
