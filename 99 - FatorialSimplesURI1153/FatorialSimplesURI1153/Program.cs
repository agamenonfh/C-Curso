using System;
using System.Globalization;

namespace FatorialSimplesURI1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fat = n;
            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 1; i < n; n--)
                {
                    fat = fat * (n - 1);
                }
                Console.WriteLine(fat);

            }
        }
    }
}