namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        public abstract string GetDescription();
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
