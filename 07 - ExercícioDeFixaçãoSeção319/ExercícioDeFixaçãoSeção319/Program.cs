using System;
using System.Globalization;

namespace ExerciocioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = (Console.ReadLine());
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto que você quer ter:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o seu úmtimo nome, idade e altura (na mesma linha somente com ' ' entre elas");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(name);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            Console.WriteLine(" Você de chama " + name + ", tem " + idade + " anos, mede " + altura + " de altura, mora numa casa com " + quartos + " quartos, e o produto que você deseja custa " + preco + " dólares australianos.");

        }
    }
}