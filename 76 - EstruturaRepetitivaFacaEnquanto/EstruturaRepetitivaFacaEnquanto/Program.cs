using System;
using System.Globalization;

namespace EstruturaRepetitivaFacaEnquanto
{
    class Program
    {

        static void Main(string[] args)
        {
            double celcius, fahrenheit;
            char repetir;

            do
            {
                Console.Write("Ditige a temperatura em Celcius: ");
                celcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fahrenheit = 9 * celcius / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + fahrenheit.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine()); 
            } while (repetir == 's');
        }
    }
}