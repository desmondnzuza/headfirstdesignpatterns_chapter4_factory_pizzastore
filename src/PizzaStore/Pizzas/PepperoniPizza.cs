using System;

namespace PizzaStore.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
            :base("Traditional Pepperoni", "Soft", "Whatever")
        {
            base.AddTopping("pepper");
        }
    }
}
