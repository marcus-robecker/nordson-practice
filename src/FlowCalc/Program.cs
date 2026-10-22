namespace FlowCalc;

public static class Calculator
{
    public static double FlowRate(double volume, double seconds) => volume / seconds;
}

public static class Program
{
    public static void Main() =>
        System.Console.WriteLine($"Flow rate: {Calculator.FlowRate(10, 2)}");
}