using System;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class MenuItem : IMenuComponent
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

        public void Add(IMenuComponent component)
        {
            throw new InvalidOperationException();
        }

        public void Remove(IMenuComponent component)
        {
            throw new InvalidOperationException();
        }

        public IMenuComponent GetChild(int componentIndex)
        {
            throw new InvalidOperationException();
        }

        public IIterator CreateIterator()
        {
            return new NullIterator();
        }
    }
}
