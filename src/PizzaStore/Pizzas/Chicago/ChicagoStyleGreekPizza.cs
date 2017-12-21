using System;

namespace PizzaStore.Pizzas.Chicago
{
    public class ChicagoStyleGreekPizza : Pizza
    {
        public override string GetDescription()
        {
            return "Chicago Greek Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing\t: Chicago Greek Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing\t\t: Chicago Greek Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up\t: Chicago Greek Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing\t: Chicago Greek Pizza");
        }
    }
}
