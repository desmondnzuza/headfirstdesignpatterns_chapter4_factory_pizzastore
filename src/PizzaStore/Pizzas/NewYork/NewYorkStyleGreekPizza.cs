using System;

namespace PizzaStore.Pizzas.NewYork
{
    public class NewYorkStyleGreekPizza : Pizza
    {
        public override string GetDescription()
        {
            return "NewYork Greek Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing\t: NewYork Greek Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing\t\t: NewYork Greek Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up\t: NewYork Greek Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing\t: NewYork Greek Pizza");
        }
    }
}
