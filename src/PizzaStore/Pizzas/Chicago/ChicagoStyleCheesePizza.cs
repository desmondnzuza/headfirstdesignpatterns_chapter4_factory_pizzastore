using System;

namespace PizzaStore.Pizzas.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public override string GetDescription()
        {
            return "Chicago Cheeze Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing\t: Chicago Cheeze Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing\t\t: Chicago Cheeze Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up\t: Chicago Cheeze Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing\t: Chicago Cheeze Pizza");
        }
    }
}
