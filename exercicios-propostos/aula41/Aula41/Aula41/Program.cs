using System;

namespace Aula41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Ler dados de duas pessoas, mostrar nome da pessoa mais velha.");
            DadosPessoais pessoa1 = new DadosPessoais(1);
            DadosPessoais pessoa2 = new DadosPessoais(2);
            if(pessoa1.GetIdade() > pessoa2.GetIdade())
                Console.WriteLine($"Pessoa mais velha: {pessoa1.GetNome()}");
            else if(pessoa2.GetIdade() > pessoa1.GetIdade())
                Console.WriteLine($"Pessoa mais velha: {pessoa2.GetNome()}");
            else
                Console.WriteLine("Ambas possuem a mesma idade.");

            Console.WriteLine("2) Ler nomes e salários, mostrar o salário médio.");
            Funcionarios funcionario1 = new Funcionarios(1);
            Funcionarios funcionario2 = new Funcionarios(2);
            Console.WriteLine($"Salário médio: {((funcionario1.GetSalario() + funcionario2.GetSalario())/2):F2}");
        }
    }
}
