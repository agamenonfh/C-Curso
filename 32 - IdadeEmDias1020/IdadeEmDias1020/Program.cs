using System;
using System.Globalization;

namespace IdadeEmDias1020
    {
    class Program
    {
        static void Main(string[] args)
        {
            int N, anos, meses, dias, sobra;
            N = int.Parse(Console.ReadLine());
            anos = N / 365;
            sobra = N % 365;
            meses = sobra / 30;
            dias = sobra % 30 ;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

        }
    }
}