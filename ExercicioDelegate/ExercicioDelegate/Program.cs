
using ExercicioDelegate;
using System.Diagnostics;

namespace treino
{
    class Program
    {
        delegate double Operation(double numberToConvert);

        static void Main(string[] args)
        {
            TemperatureConverter calc = new TemperatureConverter();
            Operation operation;

            Console.WriteLine("\r\n _____                                           \r\n/  __ \\                                          \r\n| /  \\/ ___  _ ____   _____ _ __ ___  ___  _ __  \r\n| |    / _ \\| '_ \\ \\ / / _ \\ '__/ __|/ _ \\| '__| \r\n| \\__/\\ (_) | | | \\ V /  __/ |  \\__ \\ (_) | |    \r\n \\____/\\___/|_| |_|\\_/ \\___|_|  |___/\\___/|_|    \r\n                                                 \r\n                                                 \r\n");
            Console.WriteLine();
            Console.WriteLine(" 1 - Celsius para Fahrenheit");
            Console.WriteLine(" 2 - Fahrenheit para Celsius");
            Console.Write(" Digite o número da opção: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    operation = new Operation(calc.CelsiusToFahrenheit);
                    Console.WriteLine();
                    Console.Write(" Informe a temperatura em ºC: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double resultadoEmFahrenheit = operation(celsius);
                    Console.WriteLine($"O resultado é: {resultadoEmFahrenheit}");
                    break;
                case 2:
                    operation = new Operation(calc.FahrenheitToCelsius);
                    Console.WriteLine();
                    Console.Write(" Informe a temperatura em ºF: ");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    double resultado = operation(fahrenheit);
                    Console.WriteLine($"O resultado é: {resultado}");
                    break;
            }
        }
    }
}