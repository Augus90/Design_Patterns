
using Factory;

internal class Program
{
    private static void Main(string[] args)
    {
        var chicagoStore = new ChicagoStylePizzaStrore();

        chicagoStore.orderPizza("cheese");

        var newYorkStore = new NewYorkPizzaStrore();

        newYorkStore.orderPizza("veggie");
    }
}