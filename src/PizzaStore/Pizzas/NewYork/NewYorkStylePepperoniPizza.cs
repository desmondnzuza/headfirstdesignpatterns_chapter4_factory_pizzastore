using System;

namespace PizzaStore.Pizzas.NewYork
{
    public class NewYorkStylePepperoniPizza : Pizza
    {
        public override string GetDescription()
        {
            return "NewYork Pepperoni Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Preparing\t: NewYork Pepperoni Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing\t\t: NewYork Pepperoni Pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting Up\t: NewYork Pepperoni Pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing\t: NewYork Pepperoni Pizza");
        }
    }
}
