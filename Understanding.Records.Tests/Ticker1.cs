namespace Understanding.Records.Tests;

public class Ticker1
{
    public string  Symbol    { get; set; }
    public decimal LastPrice { get; set; }

    public Ticker1(string symbol, decimal lastPrice)
    {
        LastPrice = lastPrice;
        Symbol = symbol;
    }
}
