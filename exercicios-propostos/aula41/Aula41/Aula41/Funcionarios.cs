using System;
using System.Collections.Generic;
using System.Text;

namespace Aula41
{
    class Funcionarios
    {
        private String Nome;
        private float Salario;
        public Funcionarios(int posicao)
        {
            Console.WriteLine($"Dados da {posicao}º pessoa:");
            Console.WriteLine("Nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            this.Salario = float.Parse(Console.ReadLine());
        }
        public float GetSalario()
        {
            return this.Salario;
        }
    }
}
