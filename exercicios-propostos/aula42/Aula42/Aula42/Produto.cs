using System;
using System.Collections.Generic;
using System.Text;

namespace Aula42
{
    class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;
        public Produto()
        {
            Console.WriteLine("Instanciar");
            Console.WriteLine("Produto:");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            this.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade:");
            this.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produto: {this.Nome}\nPreço: {this.Preco:F2}\nQuantidade: {this.Quantidade}");
        }
        public double ValorTotalEmEstoque()
        {
            return (this.Preco * this.Quantidade);
        }
        public void AdicionarProdutos(int qtd)
        {
            Console.WriteLine("Adicionar");
            Console.WriteLine($"Quantidade anterior: {this.Quantidade}");
            this.Quantidade += qtd;
            Console.WriteLine($"Quantidade atual: {this.Quantidade}");
        }
        public void RemoverProdutos(int qtd)
        {
            Console.WriteLine("Remover");
            Console.WriteLine($"Quantidade anterior: {this.Quantidade}");
            this.Quantidade -= qtd;
            Console.WriteLine($"Quantidade atual: {this.Quantidade}");
        }
    }
}
