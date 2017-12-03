using System;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class MenuItem : IMenu
    {
        public string Name { get; }
        public string Description { get; }
        public bool IsVegetarian { get; }
        public double Price { get; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.IsVegetarian = isVegetarian;
            this.Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {this.Name}; Description: {this.Description}; Price: {this.Price}");
        }

        public IIterator GetIterator()
        {
            return new SelfIterator(this);
        }

        public string MenuName { get; }
    }
}
