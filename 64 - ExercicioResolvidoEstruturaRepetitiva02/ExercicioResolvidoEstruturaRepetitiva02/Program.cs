using System;
using System.Globalization;

namespace ExercicioResolvidoEstruturaRepetitiva02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = 0;
            int z = 0;
            
            if (x < 0)
            {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                while (x >= 0)
                {
                    y = y + x;
                    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    z = z + 1;
                }
                Console.WriteLine( (y / z).ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}