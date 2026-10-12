using System;
using System.Globalization;

namespace Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDoFuncionario, horasTrabalhadas, valorPorHora, salario;
            numeroDoFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horasTrabalhadas * valorPorHora;
            Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}