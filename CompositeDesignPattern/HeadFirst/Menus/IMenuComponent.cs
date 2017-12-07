using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    interface IMenuComponent
    {
        string Name { get; }

        string Description { get; }

        double Price { get; }

        bool IsVegetarian { get; }

        void Print();

        void Add(IMenuComponent component);

        void Remove(IMenuComponent component);

        IMenuComponent GetChild(int componentIndex);

        IIterator CreateIterator();
    }
}