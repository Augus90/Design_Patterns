using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Pizza
    {
        protected string _name { get; set; }
        protected string _dough { get; set; }
        protected string _sauce { get; set; }
        protected List<string> _toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine($"Preparing {_name}");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine($"Adding toppings:");
            foreach (var topping in _toppings)
            {
                Console.WriteLine($" {topping}");
            }
        }
        public void bake()
        {
            Console.WriteLine($"Bake for 25 minutes...");

        }
        public void cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonal slices...");

        }
        public void box()
        {
            Console.WriteLine($"Place the pizza in the box");
        }

        public string getName()
        {
            return _name;
        }
    }
}