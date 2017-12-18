using System;
using System.Collections.Generic;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    internal class CompositeIterator : IIterator
    {
        private readonly Stack<IIterator> iterators = new Stack<IIterator>();
        private IIterator currentIterator;

        public CompositeIterator(IIterator iterator)
        {
            this.currentIterator = iterator;
            this.iterators.Push(iterator);
        }

        public bool HasNext()
        {
            return true;

            bool currentIteratorHasNext = this.currentIterator.HasNext();

            if (!currentIteratorHasNext)
            {
                if (this.iterators.Count != 0)
                {
                    return this.iterators.Peek().HasNext();
                }
            }

            return currentIteratorHasNext;
        }

        public object Next()
        {
            IMenuComponent nextComponent = (IMenuComponent)this.currentIterator.Next();

            if (nextComponent == null)
            {
                this.SetPreviousIterator();
                return this.Next();
            }

            if (nextComponent is MenuItem)
            {
                return nextComponent;
            }

            this.SetNextIteratorBasedOnComponent(nextComponent);

            return this.Next();
        }

        private void SetNextIteratorBasedOnComponent(IMenuComponent nextComponent)
        {
            this.currentIterator = nextComponent.CreateIterator();
            this.iterators.Push(this.currentIterator);
        }

        private void SaveCurrentIterator()
        {
            this.iterators.Push(this.currentIterator);
        }

        private void SetPreviousIterator()
        {
            if (this.iterators.Count != 0)
            {
                this.currentIterator = this.iterators.Pop();
            }
        }
    }
}