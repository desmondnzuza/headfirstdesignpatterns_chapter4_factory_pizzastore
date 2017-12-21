namespace PizzaStore.Pizzas.Chicago
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
            :base("Chicago Style Cheese Pepperoni", "Extra Think Crust Dough", "Normal Source")
        {
            base.AddTopping("Extra Cheese");
        }
    }
}
