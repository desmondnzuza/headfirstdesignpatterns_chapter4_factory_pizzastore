using System;

namespace PizzaStore.Pizzas.Chicago
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public override string GetDescription()
        {
            return "Chicago Pepperoni Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing\t: Chicago Pepperoni Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing\t\t: Chicago Pepperoni Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up\t: Chicago Pepperoni Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing\t: Chicago Pepperoni Pizza");
        }
    }
}
