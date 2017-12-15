using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class Menu : IMenuComponent
    {
        private ComponentCollection menuComponents = new ComponentCollection();

        public Menu(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Name { get; }

        public string Description { get; }

        public double Price => throw new InvalidOperationException();

        public bool IsVegetarian => throw new InvalidOperationException();

        public void Add(IMenuComponent component)
        {
            this.menuComponents.Add(component);
        }

        public IIterator CreateIterator()
        {
            return new CompositeIterator(this.menuComponents.GetIterator());
        }

        public IMenuComponent GetChild(int componentIndex)
        {
            return this.menuComponents[componentIndex];
        }

        public void Print()
        {
            Console.WriteLine($"{this.Name} - {this.Description}");

            IIterator iterator = menuComponents.GetIterator();

            while (iterator.HasNext())
            {
                IMenuComponent component = (IMenuComponent)iterator.Next();
                component.Print();
            }
        }

        public void Remove(IMenuComponent component)
        {
            this.menuComponents.Remove(component);
        }
    }
}
