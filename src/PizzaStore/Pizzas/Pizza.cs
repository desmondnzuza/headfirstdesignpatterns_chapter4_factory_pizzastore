using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        private readonly string _name;
        private readonly string _dough;
        private readonly string _source;
        private readonly List<string> _toppings;

        internal Pizza(string name, string dough, string source)
        {
            _name = name;
            _dough = dough;
            _source = source;

            _toppings = new List<string>();
        }

        internal void AddTopping(string topping)
        {
            _toppings.Add(topping);
        }

        internal void AddToppings(string[] toppings)
        {
            _toppings.AddRange(toppings);
        }

        public string GetDescription()
        {
            return _name;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {_name}");
            Console.WriteLine($"Tossing {_dough} dough");
            Console.WriteLine($"Adding {_source} source");
            if (_toppings.Any())
            {
                Console.WriteLine("Adding Toppings: ");
                foreach (var topping in _toppings)
                {
                    Console.WriteLine($"\t :{topping}");
                }
            }
            else
            {
                Console.WriteLine("No toppings to add.");
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place Pizza in official PizzaStore box");
        }
    }
}
