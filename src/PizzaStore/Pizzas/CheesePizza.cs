namespace PizzaStore.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
            :base("Traditional Cheese", "original thin dough", "secrete source")
        {
            base.AddToppings(new[] { "Cheese", "Garlic", "Pizzastore Secrete" });
        }
    }
}
