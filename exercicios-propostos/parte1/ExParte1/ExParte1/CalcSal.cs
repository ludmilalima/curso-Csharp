using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExParte1
{
    class CalcSal
    {
        private int id, h_trab;
        private float h_valor;
        public CalcSal()
        {
            Console.WriteLine("Insira na mesma linha " +
                                "(separados por espaços simples) " +
                                "os seguintes dados do funcionário:\n" +
                                "Número de identificação;\n" +
                                "Total de horas trabalhadas;" +
                                "\nValor por hora.");
            String[] vet = Console.ReadLine().Split();
            id = int.Parse(vet[0]);
            h_trab = int.Parse(vet[1]);
            h_valor = float.Parse(vet[2]);
        }
        public int GetId()
        {
            return this.id;
        }
        public float CalcularSal()
        {
            return (float)h_trab * h_valor;
        }
    }
}
