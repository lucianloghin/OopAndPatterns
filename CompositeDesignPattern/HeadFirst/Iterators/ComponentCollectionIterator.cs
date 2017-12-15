using CompositeDesignPattern.HeadFirst.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.HeadFirst.Iterators
{
    class ComponentCollectionIterator : IIterator
    {
        private List<IMenuComponent>.Enumerator enumerator;
        private int currentIndex = 0;
        private int collectionLength;

        public ComponentCollectionIterator(List<IMenuComponent> collection)
        {
            this.enumerator = collection.GetEnumerator();
            this.collectionLength = collection.Count;
        }

        public bool HasNext()
        {
            return currentIndex < collectionLength;
        }

        public object Next()
        {
            currentIndex++;
            enumerator.MoveNext();
            return enumerator.Current;
        }
    }
}
