namespace PizzaStore.Pizzas.NewYork
{
    public class NewYorkStyleGreekPizza : Pizza
    {
        public NewYorkStyleGreekPizza()
            :base("Traditional Pepperoni", "Thin Crust Dough", "Marina Source")
        {
            base.AddTopping("Grated Ragiano Cheese");
        }
    }
}
