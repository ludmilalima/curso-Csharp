using System;
using System.Collections.Generic;
using System.Globalization;

namespace aula23
{
    class Program
    {
        static void Main(string[] args)
        {
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
