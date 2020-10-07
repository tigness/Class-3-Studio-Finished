using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class MenuItem
    {
        double price;
        string itemName;
        string itemDescription;
        string category;
        bool isNew;

        public MenuItem(string itemName, string itemDescription, double price, string category)
        {
            this.itemName = itemName;
            this.itemDescription = itemDescription;
            this.category = category;
            this.price = price;
            isNew = true;
        }

        public double Price { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

    }

    class Menu
    {
        List<MenuItem> fullMenu = new List<MenuItem>();
        DateTime lastUpdated;

        public Menu(List<MenuItem> newMenu)
        {
            this.fullMenu = newMenu;
            lastUpdated = DateTime.Now;
        }

    }
}

