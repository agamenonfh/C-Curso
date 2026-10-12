using System;
using System.Globalization;

namespace FibonacciFacilURI1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n;

            n = int.Parse(Console.ReadLine());

            a = 0;
            b = 1;
            for (int i = 0; i < n; i = i + 1)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(a);

                }
                else
                {
                    Console.Write(a + " ");
                    
                }
                int aux = b;
                b = a;
                a = aux + b;
            }
        }
    }
}