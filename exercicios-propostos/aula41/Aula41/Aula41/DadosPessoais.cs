using System;
using System.Collections.Generic;
using System.Text;

namespace Aula41
{
    class DadosPessoais
    {
        private String Nome;
        private int Idade;
        public DadosPessoais(int posicao)
        { 
            Console.WriteLine($"Dados da {posicao}º pessoa:");
            Console.WriteLine("Nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            this.Idade = int.Parse(Console.ReadLine());
        }
        public int GetIdade()
        {
            return this.Idade;
        }
        public String GetNome()
        {
            return this.Nome;
        }
    }
}
