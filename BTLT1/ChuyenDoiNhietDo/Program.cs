using System;

static class Program
{
    static void Main(string[] args)
    {
        decimal Celsius = decimal.Parse(Console.ReadLine());
        decimal Fahrenheit = Celsius * 9m / 5m + 32m;
        decimal Kelvin = Celsius + 273.15m;
        Console.WriteLine($"Nhiệt độ Fahrenheit: {Fahrenheit:F2}");
        Console.WriteLine($"Nhiệt độ Kelvin: {Kelvin:F2}");


    }
}
