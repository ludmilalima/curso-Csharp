using System;
using System.Collections.Generic;
using System.Globalization;

namespace aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtde_q = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um preço de produto:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");

            string[] dados = Console.ReadLine().Split(' ');
            string sobrenome = dados[0];
            int idade = int.Parse(dados[1]);
            float altura = float.Parse(dados[2]);

            Console.WriteLine(nome);
            Console.WriteLine(qtde_q);
            Console.WriteLine(preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}