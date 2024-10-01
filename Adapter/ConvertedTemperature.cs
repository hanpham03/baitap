using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class ConvertedTemperature :  Temperature
    {
        private double fahrenheit;
        private TemperatureConverter converter;

        // Constructor

        public ConvertedTemperature(double celsius)
        {
            this.celsius = celsius;
        }

        public override void Display()
        {
            // The Adaptee

            converter = new TemperatureConverter();

            fahrenheit = converter.ConvertCelsiusToFahrenheit(celsius);

            Console.WriteLine("\nTemperature in Celsius: {0}°C ------ ", celsius);
            Console.WriteLine(" Temperature in Fahrenheit: {0}°F", fahrenheit);
        }
    }
}
