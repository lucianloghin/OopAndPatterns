using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.HeadFirst.Menus;

namespace CompositeDesignPattern.HeadFirst.Iterators
{
    class DesertMenuIterator : IIterator
    {
        private List<MenuItem>.Enumerator enumerator;

        public DesertMenuIterator(List<MenuItem> menuItems)
        {
            this.enumerator = menuItems.GetEnumerator();
        }

        public bool HasNext()
        {
            return this.enumerator.MoveNext();
        }

        public object Next()
        {
            return this.enumerator.Current;
        }
    }
}
