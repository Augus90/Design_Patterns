using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this._name = "Chicago Style Cheese Pizza";
            this._dough = "Extra Thicc Crust dough";
            this._sauce = "Plum Tomato sauce";

            this._toppings.Add("Mozzarella Cheese");
        }
    }
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            this._name = "Chicago Style Pepperoni Pizza";
            this._dough = "Extra Thicc Crust dough";
            this._sauce = "Plum Tomato sauce";

            this._toppings.Add("Pepperoni");
        }
    }
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            this._name = "Chicago Style Veggie Pizza";
            this._dough = "Extra Thicc Crust dough";
            this._sauce = "Plum Tomato sauce";

            this._toppings.Add("onion");
            this._toppings.Add("mushrooms");
        }
    }

    public class ChicagoStylePizzaStrore : PizzaStore
    {
        public override Pizza createPizza(string typeOfPizza)
        {
            Pizza pizza = null;

            switch (typeOfPizza)
            {
                case "cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case "veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
                default:
                    Console.WriteLine($"Not a pizza");
                    break;
            }

            return pizza;
        }
    }
}