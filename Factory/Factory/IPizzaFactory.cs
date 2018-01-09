namespace Factory
{
    interface IPizzaFactory
    {
        Pizza CreatePizza(PizzaType pizzaType);
    }
}