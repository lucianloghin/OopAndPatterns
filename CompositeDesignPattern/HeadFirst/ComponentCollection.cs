using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.HeadFirst.Menus;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst
{
    class ComponentCollection : IIteratable
    {
        private List<IMenuComponent> collection = new List<IMenuComponent>();

        internal IMenuComponent this[int index]
        {
            get
            {
                return collection[index];
            }
        }

        public IIterator GetIterator()
        {
            return new ComponentCollectionIterator(collection);
        }

        internal void Add(IMenuComponent component)
        {
            this.collection.Add(component);
        }

        internal void Remove(IMenuComponent component)
        {
            this.collection.Remove(component);
        }
    }
}
