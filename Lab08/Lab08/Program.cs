using Lab08;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Cream creamCoffee = new Cream(new Coffee());
        Console.WriteLine("Coffee with cream: " + string.Format("{0:0.00}", creamCoffee.GetPrice()));

        Syrup syrupCoffee = new Syrup(new Coffee());
        Console.WriteLine("Coffee with syrup: " + string.Format("{0:0.00}", syrupCoffee.GetPrice()));

        Sugar sugarCoffee = new Sugar(new Coffee());
        Console.WriteLine("Coffee with sugar: " + string.Format("{0:0.00}", sugarCoffee.GetPrice()));

        Vanilla vanillaCoffee = new Vanilla(new Coffee());
        Console.WriteLine("Coffee with vanilla: " + string.Format("{0:0.00}", vanillaCoffee.GetPrice()));

        Espresso espressoCoffee = new Espresso(new Coffee());
        Console.WriteLine("Coffee with espresso: " + string.Format("{0:0.00}", espressoCoffee.GetPrice()));

        Cream creamTea = new Cream(new Tea());
        Console.WriteLine("Tea with cream: " + string.Format("{0:0.00}", creamTea.GetPrice()));

        Syrup syrupTea = new Syrup(new Tea());
        Console.WriteLine("Tea with syrup: " + string.Format("{0:0.00}", syrupTea.GetPrice()));

        Sugar sugarTea = new Sugar(new Tea());
        Console.WriteLine("Tea with sugar: " + string.Format("{0:0.00}", sugarTea.GetPrice()));

        Vanilla vanillaTea = new Vanilla(new Tea());
        Console.WriteLine("Tea with vanilla: " + string.Format("{0:0.00}", vanillaTea.GetPrice()));

        Espresso espressoTea = new Espresso(new Tea());
        Console.WriteLine("Tea with espresso: " + string.Format("{0:0.00}", espressoTea.GetPrice()));
    }
}
