using System;
using System.Collections.Generic;
using System.Text;

namespace ExParte1
{
    class GeoForm
    {
        private float A, B, C;
        public GeoForm()
        {
            Console.WriteLine("Insira três valores com ponto flutuante de dupla precisão: A, B e C" +
                                "(na mesma linha separados por espaços)");
            String[] vet = Console.ReadLine().Split();
            A = float.Parse(vet[0]);
            B = float.Parse(vet[1]);
            C = float.Parse(vet[2]);
        }
        public float triangulo()
        {
            return (A * C) / 2;
        }
        public float circulo()
        {
            return (float)Math.PI * (float)Math.Pow(C, 2);
        }
        public float trapezio()
        {
            return ((A + B) * C) / 2;
        }
        public float quadrado()
        {
            return (float)Math.Pow(B,2);
        }
        public float retangulo()
        {
            return A * B;
        }
    }
}
