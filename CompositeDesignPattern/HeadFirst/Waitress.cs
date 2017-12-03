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
        private List<IMenu> menus;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            IEnumerator<IMenu> enumerator = this.menus.GetEnumerator();

            while (enumerator.MoveNext())
            {
                this.PrintMenu(enumerator.Current.GetIterator());
            }

            enumerator.Dispose();
        }

        private void PrintMenu(IIterator menuIterator)
        {
            while (menuIterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)menuIterator.Next();
                if (menuItem != null)
                {
                    menuItem.Print();
                }
            }
        }

        public void PrintBreakfastMenu()
        {
        }

        public void PrintLunchMenu()
        {
        }

        public void PrintVegetarianMenu()
        {
        }

        public bool IsItemVegetarian(string name)
        {
            return false;
        }
    }
}
