using System;

namespace Adapter.RealWorld
{
    /// <summary>
    /// Adapter Design Pattern Example: Temperature Converter
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Non-adapted temperature in Celsius

            Temperature unknownTemp = new Temperature();
            unknownTemp.Display();

            // Adapted temperatures with Fahrenheit conversion

            Temperature celsiusTemp = new ConvertedTemperature(25);
            celsiusTemp.Display();

            Temperature freezingPointTemp = new ConvertedTemperature(0);
            freezingPointTemp.Display();

            Temperature boilingPointTemp = new ConvertedTemperature(100);
            boilingPointTemp.Display();

            // Wait for user

            Console.ReadKey();
        }
    }

}
