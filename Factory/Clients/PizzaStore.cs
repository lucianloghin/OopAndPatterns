using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class PizzaStore
    {
        private readonly IPizzaFactory pizzaFactory;

        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public void OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza = this.pizzaFactory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
