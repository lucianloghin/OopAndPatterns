using System;
using System.Collections.Generic;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    internal class CompositeIterator : IIterator
    {
        private IIterator iterator;
        private ComponentCollection collection;
        private Stack<IIterator> iterators = new Stack<IIterator>();

        public CompositeIterator(IIterator iterator)
        {
            this.iterator = iterator;
        }

        public bool HasNext()
        {
            bool hasNext = this.iterator.HasNext();

            if (!hasNext)
            {
                if (this.iterators.Count != 0)
                {
                    return this.iterators.Peek().HasNext();
                }
            }

            return hasNext;
        }

        public object Next()
        {
            IMenuComponent nextComponent = this.GetNextComponent();
            
            if (nextComponent is MenuItem)
            {
                return nextComponent;
            }

            this.SetNextIteratorBasedOnComponent(nextComponent);

            return this.Next();
        }

        private void SetNextIteratorBasedOnComponent(IMenuComponent nextComponent)
        {
            this.iterator = nextComponent.CreateIterator();
            this.iterators.Push(this.iterator);
        }

        private IMenuComponent GetNextComponent()
        {
            return (IMenuComponent)this.iterator.Next();
        }

        private IMenuComponent GetNextBasedOnCurrentComponent(IMenuComponent component)
        {
            if (component is MenuItem)
            {
                this.SetPreviousIterator();
                return component;
            }

            this.SaveCurrentIterator();
            IMenuComponent nextComponent = this.GetNextComponent();

            return this.GetNextBasedOnCurrentComponent(nextComponent);
        }



        private void SaveCurrentIterator()
        {
            this.iterators.Push(this.iterator);
        }

        private void SetPreviousIterator()
        {
            if (this.iterators.Count != 0)
            {
                this.iterator = this.iterators.Pop();
            }
        }
    }
}