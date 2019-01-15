using System;

namespace _05._1.TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine($"{FahrenheitToCelsius(fahrenheit):f2}");
        }
        
        static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = ((fahrenheit - 32) * 5) / 9;
            return celsius;
        }
    }
}
