using System;
using System.Globalization;

namespace PUMURI1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pum = 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((pum - 3) + " " + (pum - 2) + " " + (pum - 1) + " PUM");
                pum = pum + 4;
            }
        }
    }
}