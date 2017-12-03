using System.Collections;

namespace CompositeDesignPattern.HeadFirst.Iterators
{
    class PancakeHouseIterator : IIterator
    {
        private ArrayList items;
        private int currentItemIndex = 0;

        public PancakeHouseIterator(ArrayList items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return this.currentItemIndex < this.items.Count;
        }

        public object Next()
        {
            return items[currentItemIndex++];
        }
    }
}
