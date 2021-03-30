using System;
using System.Collections.Generic;
using System.Text;

namespace ExParte1
{
    class CalcTotal
    {
        private int cod, qtdade;
        private float preco;
        public CalcTotal(int id)
        {
            Console.WriteLine($"Insira o código, a quantidade e o preço da peça {id} " +
                                $"(mesma linha, separados por espaços simples)");
            String[] vet = Console.ReadLine().Split();
            cod = int.Parse(vet[0]);
            qtdade = int.Parse(vet[1]);
            preco = float.Parse(vet[2]);
        }
        public float CalcularTotal()
        {
            return qtdade * preco;
        }
    }
}
