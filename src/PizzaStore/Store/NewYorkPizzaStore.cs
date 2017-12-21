using System;
using PizzaStore.Pizzas;
using PizzaStore.Pizzas.NewYork;

namespace PizzaStore.Store
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new NewYorkStyleCheesePizza();
            }

            if (type.Equals("Greek"))
            {
                return new NewYorkStyleGreekPizza();
            }

            if (type.Equals("Pepperoni"))
            {
                return new NewYorkStylePepperoniPizza();
            }

            throw new NotSupportedException(nameof(type));
        }
    }
}
