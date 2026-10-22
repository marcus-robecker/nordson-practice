using FlowCalc;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void FlowRate_10_over_2_is_5() =>
        Assert.Equal(5, Calculator.FlowRate(10, 2));
}