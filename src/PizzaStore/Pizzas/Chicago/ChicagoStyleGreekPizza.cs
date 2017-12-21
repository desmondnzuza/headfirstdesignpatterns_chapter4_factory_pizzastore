namespace PizzaStore.Pizzas.Chicago
{
    public class ChicagoStyleGreekPizza : Pizza
    {
        public ChicagoStyleGreekPizza()
            :base("Chicago Style Greek", "Extra Think Crust Dough", "Normal Source")
        {
            AddToppings(new []{ "Shredded Mozzarella Cheese" , "Extra Cheese" });
        }
    }
}
