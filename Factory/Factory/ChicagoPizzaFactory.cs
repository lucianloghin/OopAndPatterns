using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    class ChicagoPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();

                case PizzaType.Pepperoni:
                    return new VeggiePizza();

                case PizzaType.Veggie:
                    return new ChicagoPizza();

                default:
                    throw new InvalidOperationException("Invalid Pizza Type");
            }
        }
    }
}
