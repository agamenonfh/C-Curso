using System;
using System.Globalization;

namespace ExemploEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            int horas;

            Console.WriteLine("olá, quantas horas ?");
            
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine("Boa Tarde!");
                }
                else
                {
                    Console.WriteLine("Boa Noite!");
                }
            }
            Console.ReadLine();
           


        }
    }
}