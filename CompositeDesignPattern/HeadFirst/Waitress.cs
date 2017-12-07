using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.HeadFirst.Iterators;
using CompositeDesignPattern.HeadFirst.Menus;

namespace CompositeDesignPattern.HeadFirst
{
    class Waitress
    {
        private IMenuComponent menus;

        public Waitress(IMenuComponent menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            menus.Print();
        }

        public void PrintBreakfastMenu()
        {
        }

        public void PrintLunchMenu()
        {
        }

        public void PrintVegetarianMenu()
        {
            IIterator iterator = this.menus.CreateIterator();
            while(iterator.HasNext())
            {
                IMenuComponent component = (IMenuComponent)iterator.Next();
                if (component.IsVegetarian)
                {
                    component.Print();
                }
            }
        }

        public bool IsItemVegetarian(string name)
        {
            return false;
        }
    }
}
