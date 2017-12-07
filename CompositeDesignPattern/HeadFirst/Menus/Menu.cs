using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class Menu : IMenuComponent
    {
        private List<IMenuComponent> menuComponents = new List<IMenuComponent>();

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

        public IMenuComponent GetChild(int componentIndex)
        {
            return this.menuComponents[componentIndex];
        }

        public void Print()
        {
            Console.WriteLine($"{this.Name} - {this.Description}");

            foreach (IMenuComponent component in menuComponents)
            {
                component.Print();
            }
        }

        public void Remove(IMenuComponent component)
        {
            this.menuComponents.Remove(component);
        }
    }
}
