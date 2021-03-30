using System;

namespace ExParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução dos 6 exercícios propostos na parte 1:");

            Console.WriteLine("1) Ler dois inteiros e calcular a soma destes.");
            Soma resultado = new Soma();
            Console.WriteLine($"Resultado: {resultado.Somar()}\n");

            Console.WriteLine("2) Ler o valor do raio de um círculo e calcular a área deste.");
            CalcArea area = new CalcArea();
            Console.WriteLine($"Área: {area.CalcularArea():F4}\n");

            Console.WriteLine("3) Ler os inteiros A, B, C e D e calcular a diferença A*B-C*D.");
            CalcDif diferenca = new CalcDif();
            Console.WriteLine($"Diferença: {diferenca.CalcularDif()}");

            Console.WriteLine("4) Ler informações de um funcionário e calcular o salário deste.");
            CalcSal funcionario = new CalcSal();
            Console.WriteLine($"Id. funcionário: {funcionario.GetId()}\nSalário: {funcionario.CalcularSal():F2}");

            Console.WriteLine("5) Ler informações de dois produtos e calcular o preço final.");
            CalcTotal prod1 = new CalcTotal(1);
            CalcTotal prod2 = new CalcTotal(2);
            Console.WriteLine($"Valor a pagar: R${(prod1.CalcularTotal() + prod2.CalcularTotal()):F2}");

            Console.WriteLine("6) Ler três números reais e calcular as áreas das figuras germétricas.");
            GeoForm forma = new GeoForm();
            Console.WriteLine($"Triângulo: {forma.triangulo():F3}\n" +
                                $"Círculo: {forma.circulo():F3}\n" +
                                $"Trapézio: {forma.trapezio():F3}\n" +
                                $"Quadrado: {forma.quadrado():F3}\n" +
                                $"Retângulo: {forma.retangulo():F3}\n");
        }
    }
}
