using System.Collections;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class PancakeHouseMenu
    {
        private readonly ArrayList menuItems = new ArrayList();
        public string MenuName { get; }

        public PancakeHouseMenu()
        {
            this.MenuName = "Pancake Menu";
            
            this.AddItem("Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            this.AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            this.AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            this.AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public IIterator GetIterator()
        {
            return new PancakeHouseIterator(this.menuItems);
        }

        public void PrintMenu()
        {
            foreach (MenuItem item in this.menuItems)
            {
                item.Print();
            }
        }

        public void PrintBreakfastMenu()
        {
            throw new System.NotImplementedException();
        }

        public void PrintLunchMenu()
        {
            throw new System.NotImplementedException();
        }

        public void PrintVegetarianMenu()
        {
            throw new System.NotImplementedException();
        }

        public bool IsItemVegetarian(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
