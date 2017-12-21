using System;

namespace PizzaStore.Pizzas.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
            :base("Chicago Style Cheese", "Extra Think Crust Dough", "Plum Tomato Source")
        {
            base.AddTopping("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
