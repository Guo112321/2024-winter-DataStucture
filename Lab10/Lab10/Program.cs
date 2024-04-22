using Lab10;

class Program
{
    static void Main(string[] args)
    {
        StockMarket market = new StockMarket();
        Investor sorros = new Investor("Sorros");
        Investor berkshire = new Investor("Berkshire");

        market.Attach(sorros);
        market.Attach(berkshire);

        market.Notify("IBM", 120.10);
        market.Notify("IBM", 121.00);
        market.Notify("IBM", 120.50);
        market.Notify("IBM", 120.75);
    }
}
