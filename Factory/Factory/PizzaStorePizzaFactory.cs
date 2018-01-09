using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class PizzaStorePizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();

                case PizzaType.Pepperoni:
                    return new PepperoniPizza();

                case PizzaType.Veggie:
                    return new VeggiePizza();

                default:
                    throw new InvalidOperationException("Invalid Pizza Type");
            }
        }
    }

    interface IPizzaFactory
    {
        Pizza CreatePizza(PizzaType pizzaType);
    }
}
