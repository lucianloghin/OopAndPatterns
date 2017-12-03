using CompositeDesignPattern.HeadFirst.Menus;

namespace CompositeDesignPattern.HeadFirst.Iterators
{
    class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] items;
        private int currentItemIndex = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (currentItemIndex >= items.Length)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            object currentItem = this.items[currentItemIndex++];
            
            return currentItem;
        }
    }
}
