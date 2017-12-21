using System;

namespace PizzaStore.Pizzas
{
    public class GreekPizza : Pizza
    {
        public override string GetDescription()
        {
            return "Traditional Greek Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing\t: Traditional Greek Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing\t\t: Traditional Greek Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up\t: Traditional Greek Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing\t: Traditional Greek Pizza");
        }
    }
}
