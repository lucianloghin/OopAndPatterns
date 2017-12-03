using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class DesertMenu : MenuItem
    {
        List<MenuItem> menuItems = new List<MenuItem>();

        public DesertMenu()
            : base(null, null, false, Double.NaN)
        {
            menuItems.Add(new MenuItem("Lava cake", "Lots of chocolate", true, 3.00));
        }

        public IIterator GetIterator()
        {
            return new DesertMenuIterator(this.menuItems);
        }

        public string MenuName { get; }
    }
}
