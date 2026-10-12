using System; 
using System.Globalization;

namespace SomaDeImparesConsecutivosIIURI1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, y, soma = 0, min, max;            
                     
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
                
                if (x < y)
                {
                    min = x;
                    max = y;
                }
                else
                {
                    min = y;
                    max = x;
                }
                if (min % 2 == 0)
                {
                    min = min + 1;
                    for (soma = 0; min < max; min += 2)
                    {
                        soma = soma + min;
                    }
                }
                else
                {
                    min = min + 2;
                    for (soma = 0; min < max; min += 2)
                    {
                        soma = soma + min;
                    }
                }
               
                Console.WriteLine(soma);
            }
        }
    }
}