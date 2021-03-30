using System;
using System.Collections.Generic;
using System.Text;

namespace ExParte1
{
    class CalcArea
    {
        private double raio;
        public CalcArea()
        {
            Console.WriteLine("Digite o valor do raio:");
            raio = double.Parse(Console.ReadLine());
        }
        public double CalcularArea() 
        {
            return Math.PI * Math.Pow(raio, 2);
        }
    }
}
