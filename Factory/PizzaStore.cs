using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class PizzaStore
    {
        public Pizza pizza;
        public void orderPizza(string type)
        {

            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
        }

        public abstract Pizza createPizza(string type);
    }
}