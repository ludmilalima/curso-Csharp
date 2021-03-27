using System;
using System.Collections.Generic;
using System.Text;

namespace aula23
{
    class Singleton
    {
        private Singleton ()
        {

        }

        private static Singleton _instance;

        public static Singleton GetInstance ()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static String MethodOne ()
        {
            return "Hello, World!!!";
        }

        public String HelloAge (int age)
        {
            return ($"Hello, you've {age} years old.");
        }
    }
}
