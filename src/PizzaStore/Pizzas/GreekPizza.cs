using System;

namespace PizzaStore.Pizzas
{
    public class GreekPizza : Pizza
    {
        public GreekPizza()
            :base("Traditional Greek", "original thin dough", "secrete source")
        {
            base.AddToppings(new[] { "Cheese", "Garlic", "Pizzastore Secrete" });
        }
    }
}
