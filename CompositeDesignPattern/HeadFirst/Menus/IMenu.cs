using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    interface IMenu : IIteratable
    {
        string MenuName { get; }
    }
}