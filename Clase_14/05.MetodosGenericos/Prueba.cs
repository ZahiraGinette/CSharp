using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MetodosGenericos
{
    public class Prueba
    {
        public static void OpenTest<T>(T s, T t) where T : class
        {
            Console.WriteLine(s == t);
        }

        public void OpenTestDos<T>(T s, T t) where T : class
        {
            Console.WriteLine(s == t);
        }
    }
}
