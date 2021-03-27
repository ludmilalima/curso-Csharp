using System;
using System.Collections.Generic;
using System.Text;

namespace aula23
{

    class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public string GetName()
        {
            return "círculo";
        }
    }
}
