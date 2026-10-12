using System;
using System.Globalization;

namespace ExercicioResolvido01Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] v;
            n = int.Parse(Console.ReadLine());            
            v = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] < 0)
                {
                    Console.WriteLine(v[i]);
                }
            }
            
        }
    }
}