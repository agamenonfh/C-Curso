using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {//O comando 'string' ele lê capitura e lê a ENTRADA até a quebra de lina 'ENTER'
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //Aqui o professor introduziu o conceito de 'SPLIT'
            //Esse comnado serve para separar os dados mediante uma referênia posta 
            //Como nesse exemplo a seguir:

            //string s = Console.ReadLine(); "Entrada digitada no Prompt Comando (Programa)"
            
            //Console: batata tomate abacaxi "isso é o 'string s' eu quero que cada palavra seja respectivamente p1 p2 p3"

            //string[] vet = s.Split(' ');
            //Esse [] cada parte do 'Console' em vetor cada um por sua ordem
            //'batata' vet [0] 'tomate' vet [1] 'abacaxi' vet [2]

            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];

            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            
            //Como o 's' da string acima é '= Console.ReadLine();' pode-se escrever 'Console.ReadLine' diretamente em
            //na linha 'string[] vet = Console.ReadLine.Split(' ');

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("Até Mais!!! FLW");


            

        }

    }
}