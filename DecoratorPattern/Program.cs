using DecoratorPattern.DecoratorComponents;
using DecoratorPattern.PrimaryComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Beverage espressoWithMilk = new Milk(espresso);
            Beverage espressoWithMilkAndWhip = new Whip(espressoWithMilk);

            Console.WriteLine($"{espressoWithMilk.GetDescription()} : {espressoWithMilk.Cost()}" );
            Console.WriteLine($"{espressoWithMilkAndWhip.GetDescription()} : {espressoWithMilkAndWhip.Cost()}");
            Console.Read();
        }
    }
}
