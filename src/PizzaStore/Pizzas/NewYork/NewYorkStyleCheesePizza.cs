namespace PizzaStore.Pizzas.NewYork
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        public NewYorkStyleCheesePizza()
            :base("NY Style Cheese", "Thin Crust Dough", "Marina Source")
        {
            base.AddTopping("Grated Ragiano Cheese");
        }
    }
}
