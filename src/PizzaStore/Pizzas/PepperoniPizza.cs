using System;

namespace PizzaStore.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
            :base("Traditional Pepperoni", "original thin dough", "secrete source")
        {
            base.AddToppings(new []{"Cheese", "Garlic", "Pizzastore Secrete"});
        }
    }
}
