using System;
using System.Collections.Generic;
using System.Text;

namespace ExParte1
{
    class Soma
    {
        private int op1;
        private int op2;
        public Soma()
        {
            Console.WriteLine("Digite o primeiro operando:");
            op1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo operando:");
            op2 = int.Parse(Console.ReadLine());
        }
        public int Somar()
        {
            return op1 + op2;
        }
    }
}