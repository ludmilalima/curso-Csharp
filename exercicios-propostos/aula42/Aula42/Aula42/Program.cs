using System;

namespace Aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.AdicionarProdutos(4);
            produto1.AdicionarProdutos(2);
            produto1.RemoverProdutos(7);
            Console.WriteLine($"Valor total em estoque: {produto1.ValorTotalEmEstoque()}");
        }
    }
}
