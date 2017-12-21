namespace PizzaStore.Pizzas.NewYork
{
    public class NewYorkStylePepperoniPizza : Pizza
    {
        public NewYorkStylePepperoniPizza()
            :base("Traditional Pepperoni", "Thin Crust Dough", "Marina Source")
        {
            base.AddTopping("Grated Ragiano Cheese");
        }
    }
}
