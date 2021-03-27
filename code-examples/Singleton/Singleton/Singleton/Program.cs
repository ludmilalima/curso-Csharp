using System;
using System.Collections.Generic;
using System.Globalization;

namespace aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.MethodOne());
            Console.WriteLine(Singleton.GetInstance().HelloAge(10));
        }
    }
}
