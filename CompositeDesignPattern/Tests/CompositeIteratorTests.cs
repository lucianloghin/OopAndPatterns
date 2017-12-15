using CompositeDesignPattern.HeadFirst;
using CompositeDesignPattern.HeadFirst.Iterators;
using CompositeDesignPattern.HeadFirst.Menus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Tests
{
    [TestClass]
    public class CompositeIteratorTests
    {
        private CompositeIterator iterator;

        [TestInitialize]
        public void TestInitialize()
        {
            ComponentCollection collection = new ComponentCollection();

            IMenuComponent allMenus = new Menu("All menus", "All menus combined!");

            IMenuComponent pancakeMenu = new Menu("Pancake house menu", "Breakfast");
            IMenuComponent dinerMenu = new Menu("Dinner menu", "Lunch");
            IMenuComponent cafeMenu = new Menu("Cafe menu", "Dinner");
            IMenuComponent desertMenu = new Menu("Dessert menu", "Dessert of course!");

            allMenus.Add(pancakeMenu);
            allMenus.Add(dinerMenu);

            pancakeMenu.Add(new MenuItem("Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99));
            pancakeMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            pancakeMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));

            dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29));
            dinerMenu.Add(new MenuItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05));

            desertMenu.Add(new MenuItem("Lava cake", "it's a coffee", true, 2.00));
            desertMenu.Add(new MenuItem("Ice cream", "it's a coffee", true, 1.80));

            dinerMenu.Add(desertMenu);

            cafeMenu.Add(new MenuItem("Espresso", "it's a coffee", true, 1.40));
            cafeMenu.Add(new MenuItem("Cappuccino", "it's a coffee", true, 1.80));

            allMenus.Add(cafeMenu);

            collection.Add(allMenus);

            this.iterator = new CompositeIterator(collection.GetIterator());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.iterator = null;
        }

        [TestMethod]
        public void GetAtLeastOneLeaf()
        {
            // arrange
            int leafCounter = 0;
            string names = string.Empty;

            // act
            while (this.iterator.HasNext())
            {
                leafCounter++;
                IMenuComponent component = (IMenuComponent)this.iterator.Next();
                names += $"{component.Name};";
            }

            Assert.IsTrue(leafCounter > 0);
        }
    }
}
