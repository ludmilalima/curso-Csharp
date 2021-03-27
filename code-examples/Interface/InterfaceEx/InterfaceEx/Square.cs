using System;
using System.Collections.Generic;
using System.Text;

namespace aula23
{
    class Square : IShape
    {
        private int side;
        public Square (int side)
        {
            this.side = side;
        }
        public double CalculateArea()
        {
            return side * side;
        }

        public string GetName()
        {
            return "quadrado";
        }
    }
}
