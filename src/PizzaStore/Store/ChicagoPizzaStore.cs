using System;
using PizzaStore.Pizzas;
using PizzaStore.Pizzas.Chicago;

namespace PizzaStore.Store
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }

            if (type.Equals("Greek"))
            {
                return new ChicagoStyleGreekPizza();
            }

            if (type.Equals("Pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }

            throw new NotSupportedException(nameof(type));
        }
    }
}
