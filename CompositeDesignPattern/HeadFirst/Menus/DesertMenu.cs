using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.HeadFirst.Iterators;

namespace CompositeDesignPattern.HeadFirst.Menus
{
    class DesertMenu : Menu
    {
        public DesertMenu()
            : base("Dessert menu", "Dessert of course!")
        {
            this.Add(new MenuItem("Lava cake", "Lots of chocolate", true, 3.00));
        }
    }
}
