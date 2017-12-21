using System;

namespace PizzaStore.Pizzas.NewYork
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        public override string GetDescription()
        {
            return "NewYork Cheeze Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing\t: NewYork Cheeze Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing\t\t: NewYork Cheeze Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up\t: NewYork Cheeze Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing\t: NewYork Cheeze Pizza");
        }
    }
}
