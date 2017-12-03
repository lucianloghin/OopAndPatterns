using System;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class DinerMenu : IMenu
    {
        private const int MaxItems = 6;
        private int numberOfItems = 0;
        private readonly MenuItem[] menuItems = new MenuItem[MaxItems];
        public string MenuName { get; }

        public DinerMenu(MenuItem menu)
        {
            this.MenuName = "Diner Menu";
            
            this.AddItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            this.AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            this.AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            this.AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
            this.AddMenuItem(menu);
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

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            this.AddMenuItem(menuItem);
        }

        public IIterator GetIterator()
        {
            return new DinerMenuIterator(this.menuItems);
        }

        public void PrintMenu()
        {
            foreach (MenuItem menuItem in this.menuItems)
            {
                menuItem.Print();
            }
        }

        public void PrintBreakfastMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintLunchMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintVegetarianMenu()
        {
            throw new NotImplementedException();
        }

        public bool IsItemVegetarian(string name)
        {
            throw new NotImplementedException();
        }
    }
}
