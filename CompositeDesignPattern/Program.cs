using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesignPattern.HeadFirst;
using CompositeDesignPattern.HeadFirst.Menus;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMenu> menus = new List<IMenu>();
            
            DesertMenu desertMenu = new DesertMenu();

            var dinerMenu = new DinerMenu(desertMenu);

            menus.Add(dinerMenu);
            menus.Add(new PancakeHouseMenu());

            Waitress waitress = new Waitress(menus);
            waitress.PrintMenu();

            Console.ReadLine();
        }
    }
}
