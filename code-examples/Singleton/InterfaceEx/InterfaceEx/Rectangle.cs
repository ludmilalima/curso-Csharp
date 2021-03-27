using System;
using System.Collections.Generic;
using System.Text;

namespace aula23
{
    class Rectangle : IShape
    {
        private int _base;
        private int height;
        public Rectangle (int _base, int height)
        {
            this._base = _base;
            this.height = height;
        }
        public double CalculateArea()
        {
            return _base * height;
        }

        public string GetName()
        {
            return "retângulo";
        }
    }
}