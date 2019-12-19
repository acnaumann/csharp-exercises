using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool IsNew(DateTime fromWhen)
        {
            //if (fromWhen == null)
            //{
            //    return false;
            //}

            if (DateTime.Compare(fromWhen, DateAdded) < 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string str = "";
            str += Name + " - " + Description +
                "\n$" + Price +
                "\nCategories: " + String.Join(", ", Categories);

            return str;
        }

        public override bool Equals(object obj)
        {
            MenuItem itemObj;

            if (obj == null || (obj.GetType() != this.GetType()))
            {
                return false;
            }

            itemObj = obj as MenuItem;
            return itemObj.Name == this.Name;

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

            if (items == null)
            {
                this.Items = new List<MenuItem>();
            }
            else
            {
                this.Items = items;
            }
            
            LastUpdated = date;
        }

        public void AddMenuItem(MenuItem item)
        {
            DateTime now = DateTime.Now;

            if (item == null)
            {
                //Maybe log an error message
                return;
            }

            Items.Add(item);
            LastUpdated = now;
            item.DateAdded = now;
        }

        public void RemoveMenuItem(MenuItem item)
        {
            if (item == null)
            {
                return;
            }

            Items.Remove(item);
        }

        //public ListMenuItems()
        //{
        //    return;
        //}

        //public ListMenu()
        //{
        //    return;
        //}

        public override bool Equals(object obj)
        {
            Menu menuObj;

            if (obj == null || (obj.GetType() != this.GetType()))
            {
                return false;
            }

            menuObj = obj as Menu;

            return menuObj.Name == this.Name && menuObj.Items.SequenceEqual(this.Items);
        }

        public override string ToString()
        {
            string str = "";
            str += Name + " Menu\n" +
                String.Join("\n------\n", Items);

            return str;
        }
        //private void bool IsNew(MenuItem item)
        //{
        //    if (item.DateAdded > (DateTime.Now))
        //    {
        //        return true;
        //    }

        //}
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
                new List<MenuItem>() { pasta, tiramisu },    //what happens if you pass in null here? where is the null exeption?
                new DateTime()
                );

            Console.WriteLine("Restuarant Name: " + resMenu.Name);

            Console.WriteLine(tiramisu.Name + " " + tiramisu.Price);

            resMenu.Items[1].Price = 7.99;

            Console.WriteLine(resMenu.Items[1].Name + " " + resMenu.Items[1].Price);
            Console.WriteLine("--------");
            Console.WriteLine(tiramisu); 
            Console.WriteLine(tiramisu.Equals(new MenuItem("Tiramisu", "desc", 4.99, null, DateTime.Now)));

            Console.WriteLine(resMenu);

        }
    }
}
