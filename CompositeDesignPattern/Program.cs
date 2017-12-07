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
            IMenuComponent pancakeMenu = new Menu("Pancake house menu", "Breakfast");
            IMenuComponent dinerMenu = new Menu("Dinner menu", "Lunch");
            IMenuComponent cafeMenu = new Menu("Cafe menu", "Dinner");
            IMenuComponent desertMenu = new Menu("Dessert menu", "Dessert of course!");

            IMenuComponent allMenus = new Menu("All menus", "All menus combined!");
            allMenus.Add(pancakeMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29));
            dinerMenu.Add(new MenuItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05));

            dinerMenu.Add(desertMenu);

            pancakeMenu.Add(new MenuItem("Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99));
            pancakeMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            pancakeMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();

            Console.ReadLine();
        }
    }
}
