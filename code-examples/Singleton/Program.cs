using System;
using System.Collections.Generic;
using System.Globalization;

namespace aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtde_q = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um preço de produto:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string sobrenome = dados[1];
            int idade = int.Parse(dados[2]);
            float altura = float.Parse(dados[3], CultureInfo.InvariantCulture);*/



            /*Console.WriteLine(Singleton.GetInstance().HelloAge(45));
            Console.WriteLine(Singleton.GetInstance().HelloAge(45));*/

            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Square(4));
            shapes.Add(new Rectangle(4,5));
            shapes.Add(new Circle(2));
            //var itemType = "";
            foreach (var item in shapes)
            {
                /*if (item is Square) 
                {
                    itemType = "quadrado";
                }
                else if (item is Rectangle)
                {
                    itemType = "retângulo";
                }
                else
                {
                    itemType = "indefinido";
                }*/
                Console.WriteLine($"Área do {item.GetName()} é: {item.CalculateArea():F2}");
            }
        }
    }
}
