using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class SelfIterator : IIterator
    {
        private readonly MenuItem _menuItem;
        private bool alreadyIterated = false;

        public SelfIterator(MenuItem menuItem)
        {
            _menuItem = menuItem;
        }
        
        public bool HasNext()
        {
            if (alreadyIterated)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            alreadyIterated = true;
            return this;
        }
    }
}