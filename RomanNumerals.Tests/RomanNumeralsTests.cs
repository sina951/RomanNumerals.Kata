using Xunit;
using FluentAssertions;

namespace RomanNumerals.Tests;

public class RomanNumeralsTests
{
    [Fact]
    public void zero_should_return_empty_string()
    {
        // act
        var result = RomanNumerals.makeRoman(0);
        // assert
        result.Should().Be(string.Empty);
    }
    [Fact]
    public void one_should_return_I()
    {
        // act
        var result = RomanNumerals.makeRoman(1);
        // assert
        result.Should().Be("I");
    }
    [Fact]
    public void thousand_should_return_M()
    {
        // act
        var result = RomanNumerals.makeRoman(1000);
        // assert
        result.Should().Be("M");
    }
}