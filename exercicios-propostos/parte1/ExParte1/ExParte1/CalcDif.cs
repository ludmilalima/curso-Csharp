using System;
using System.Collections.Generic;
using System.Text;

namespace ExParte1
{
    class CalcDif
    {
        private int A, B, C, D;
        public CalcDif()
        {
            Console.WriteLine("Insira os valores A, B, C e D na mesma linha separados por espaço simples:");
            String[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);
        }
        public int CalcularDif()
        {
            return A * B - C * D;
        }
    }
}
