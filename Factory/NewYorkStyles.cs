using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    public class NewYorkCheesePizza : Pizza
    {
        public NewYorkCheesePizza()
        {
            this._name = "New York Style Cheese Pizza";
            this._dough = "Thin Crust dough";
            this._sauce = "Marinara sauce";

            this._toppings.Add("Mozzarella Cheese");
        }
    }
    public class NewYorkPepperoniPizza : Pizza
    {
        public NewYorkPepperoniPizza()
        {
            this._name = "New York Style Pepperoni Pizza";
            this._dough = "Thin Crust dough";
            this._sauce = "Marinara sauce";

            this._toppings.Add("Pepperoni");
        }
    }
    public class NewYorkVeggiePizza : Pizza
    {
        public NewYorkVeggiePizza()
        {
            this._name = "New York Style Veggie Pizza";
            this._dough = "Thin Crust dough";
            this._sauce = "Marinara sauce";

            this._toppings.Add("onion");
            this._toppings.Add("mushrooms");
        }
    }

    public class NewYorkPizzaStrore : PizzaStore
    {
        public override Pizza createPizza(string typeOfPizza)
        {
            Pizza pizza = null;

            switch (typeOfPizza)
            {
                case "cheese":
                    pizza = new NewYorkCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new NewYorkPepperoniPizza();
                    break;
                case "veggie":
                    pizza = new NewYorkVeggiePizza();
                    break;
                default:
                    Console.WriteLine($"Not a pizza");
                    break;
            }

            return pizza;
        }
    }
}