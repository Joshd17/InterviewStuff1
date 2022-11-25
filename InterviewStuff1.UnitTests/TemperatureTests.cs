using FluentAssertions;
using InterviewStuff1.Domain;
using System;
using Xunit;

namespace InterviewStuff1.UnitTests;
public class TemperatureTests
{
    private const decimal PrecisionToTest = 0.0000000001m;

    [Theory]
    [InlineData("-17.7722222222", "0.01")]
    [InlineData("-17.7222222222", "0.1")]
    [InlineData("-17.2222222222", "1")]
    [InlineData("-16.6666666667", "2")]
    [InlineData("-16.1111111111", "3")]
    [InlineData("-15", "5")]
    [InlineData("-12.2222222222", "10")]
    [InlineData("-6.6666666667", "20")]
    [InlineData("10", "50")]
    [InlineData("37.7777777778", "100")]
    [InlineData("537.7777777778", "1000")]
    public void TemperatureWithCelsiusSet_ConvertsToF(string c, string expectedF)
    {
        var decimalC = decimal.Parse(c);
        var decimalF = decimal.Parse(expectedF);

        var temp = Temperature.FromCelcius(decimalC).Farenheit;

        temp.Should().BeApproximately(decimalF, PrecisionToTest);
    }

    [Theory]
    [InlineData("-17.7722222222")]
    [InlineData("-17.7222222222")]
    [InlineData("-17.2222222222")]
    [InlineData("-16.6666666667")]
    [InlineData("-16.1111111111")]
    [InlineData("-15")]
    [InlineData("-12.2222222222")]
    [InlineData("-6.6666666667")]
    [InlineData("10")]
    [InlineData("37.7777777778")]
    [InlineData("537.7777777778")]
    public void TemperatureWithCelsiusSet_SetsCelsiusCorrectly(string c)
    {
        var decimalC = decimal.Parse(c);

        var temp = Temperature.FromCelcius(decimalC).Celcius;

        temp.Should().BeApproximately(decimalC, PrecisionToTest);
    }

    [Theory]
    [InlineData("15.8", "-9")]
    [InlineData("30.2", "-1")]
    [InlineData("32", "0")]
    [InlineData("33.8", "1")]
    [InlineData("35.6", "2")]
    [InlineData("37.4", "3")]
    [InlineData("41", "5")]
    [InlineData("50", "10")]
    [InlineData("66.2", "19")]
    public void TemperatureWithFSet_ConvertsToC(string f, string expectedC)
    {
        var decimalF = decimal.Parse(f);
        var decimalC = decimal.Parse(expectedC);

        var temp = Temperature.FromF(decimalF).Celcius;

        temp.Should().BeApproximately(decimalC, PrecisionToTest);
    }

    [Theory]
    [InlineData("-17.7722222222")]
    [InlineData("-17.7222222222")]
    [InlineData("-17.2222222222")]
    [InlineData("-16.6666666667")]
    [InlineData("-16.1111111111")]
    [InlineData("-15")]
    [InlineData("-12.2222222222")]
    [InlineData("-6.6666666667")]
    [InlineData("10")]
    [InlineData("37.7777777778")]
    [InlineData("537.7777777778")]
    public void TemperatureWithFSet_SetsFCorrectly(string f)
    {
        var decimalF = decimal.Parse(f);

        var temp = Temperature.FromF(decimalF).Farenheit;

        temp.Should().BeApproximately(decimalF, PrecisionToTest);
    }
}
