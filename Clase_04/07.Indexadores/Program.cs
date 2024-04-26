using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dias dia = new Dias();
            Console.WriteLine(dia[2]);
            dia[4] = "Dia imaginario";
            Console.WriteLine(dia[4]);
            Console.WriteLine(dia[5]);
            Console.ReadKey();
        }
    }
}
