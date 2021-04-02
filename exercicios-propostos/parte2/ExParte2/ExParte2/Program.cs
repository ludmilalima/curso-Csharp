using System;

namespace ExParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois valores na mesma linha, separados por espaço simples:");
            String[] vet = Console.ReadLine().Split();
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A >= 0 && B >= 0)
                Console.WriteLine("A e B são positivos;");
            else if(A < 0 && B < 0)
                Console.WriteLine("A e B são negativos;");
            else if(A >= 0 && B < 0)
                Console.WriteLine("A é positivo e B é negativo;");
            else
                Console.WriteLine("A é negativo e B é positivo;");

            if ((A % 2) == 0 && (B % 2) == 0)
                Console.WriteLine("A e B são pares;");
            else if ((A % 2) != 0 && (B % 2) != 0)
                Console.WriteLine("A e B são ímpares;");
            else if ((A % 2) == 0 && (B % 2) != 0)
                Console.WriteLine("A é par e B é ímpar;");
            else
                Console.WriteLine("A é ímpar e B é par;");

            if((A % B) == 0 || (B % A) == 0)
                Console.WriteLine("A e B são múltiplos.");
            else
                Console.WriteLine("A e B não são múltiplos.");
        }
    }
}
