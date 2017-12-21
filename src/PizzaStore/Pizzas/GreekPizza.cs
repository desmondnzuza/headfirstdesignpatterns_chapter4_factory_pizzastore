using System;

namespace PizzaStore.Pizzas
{
    public class GreekPizza : Pizza
    {
        public GreekPizza()
            :base("Traditional Greek", "Soft", "Whatever")
        {
            base.AddTopping("garlic");
        }
    }
}
