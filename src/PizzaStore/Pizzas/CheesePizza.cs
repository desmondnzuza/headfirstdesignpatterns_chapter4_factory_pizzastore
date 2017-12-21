namespace PizzaStore.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
            :base("Traditional Cheese", "Soft", "Whatever")
        {
            base.AddTopping("Extra Cheese");
        }
    }
}
