using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDelegate
{
    public class TemperatureConverter
    {

        public double CelsiusToFahrenheit(double celsius)
        {
            //°F = (°C x 9 / 5) +32
            double calc = (celsius * 9 / 5) + 32;
            double Fahrenheit = calc;

            return Fahrenheit;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            //°C = (°F - 32) x 5 / 9
            double calc = (fahrenheit - 32) * 5 / 9;

            double celsius = calc;
            return celsius;
        }

     
    }
}
