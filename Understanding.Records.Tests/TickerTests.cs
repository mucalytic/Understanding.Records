using FluentAssertions;

namespace Understanding.Records.Tests;

public class TickerTests
{
    [Fact]
    public void HashSetOfClass_MatchesKeysByReference()
    {
        // arrange
        var tickers = new HashSet<Ticker1> { new("WHATEVER", 150m) };

        // act
        // assert
        tickers.Should().NotContain(new Ticker1("WHATEVER", 150m));
    }

    [Fact]
    public void HashSetOfRecord_MatchesKeysByValue()
    {
        // arrange
        var tickers = new HashSet<Ticker2> { new("WHATEVER", 150m) };

        // act
        // assert
        tickers.Should().Contain(new Ticker2("WHATEVER", 150m));
    }
}
