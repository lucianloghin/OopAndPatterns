using System;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class DinerMenu : Menu
    {
        private const int MaxItems = 6;
        private int numberOfItems = 0;
        private readonly MenuItem[] menuItems = new MenuItem[MaxItems];

        public DinerMenu()
            : base("Diner menu", "Lunch")
        {            
            this.AddItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            this.AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            this.AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            this.AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            this.AddMenuItem(menuItem);
        }
        
        public void Add(IMenuComponent component)
        {
            throw new NotImplementedException();
        }

        public void Remove(IMenuComponent component)
        {
            throw new NotImplementedException();
        }

        public IMenuComponent GetChild(int componentIndex)
        {
            throw new NotImplementedException();
        }

        private void AddMenuItem(MenuItem menu)
        {
            if (numberOfItems >= MaxItems)
            {
                throw new ApplicationException("Sorry, menu is full!");
            }
            else
            {
                menuItems[numberOfItems] = menu;
                numberOfItems++;
            }
        }
    }
}
