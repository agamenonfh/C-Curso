using System;
using System.Globalization;

namespace SequenciaIJURI1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta = 0;
            for (int i = 0; i < 15; i++)
            {
                if (i < 3)
                {
                    conta = conta + 1;
                    int J = 8 - conta;
                    Console.WriteLine("I=1 J=" + J);
                }
                else if (i < 6)
                {
                    conta = conta + 1;
                    int J = 11 - conta;
                    Console.WriteLine("I=3 J=" + J);
                }
                else if (i < 9)
                {
                    conta = conta + 1;
                    int J = 14 - conta;
                    Console.WriteLine("I=5 J=" + J);
                }
                else if (i < 12)
                {
                    conta = conta + 1;
                    int J = 17 - conta;
                    Console.WriteLine("I=7 J=" + J);
                }
                else
                {
                    conta = conta + 1;
                    int J = 20 - conta;
                    Console.WriteLine("I=9 J=" + J);
                }
            }
        }
    }
}
//PROFESSOR﻿
class URI
{
    static void Main(string[] args)
    {

        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = 7; j >= 5; j--)
            {
                Console.Write("I=" + i + " J=" + j + "\n");
            }
        }
    }
}