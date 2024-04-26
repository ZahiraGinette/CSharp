using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();  
            Console.WriteLine(random.Next(-10, 100));
            Console.WriteLine(random.Next(-2, 2));
            Console.WriteLine(random.Next(-2, 2));
            Console.WriteLine(random.Next(-2, 2));
            Console.WriteLine(random.Next(-2, 2));
            Console.WriteLine(random.Next(-2, 2)); 
            Console.WriteLine(random.Next(-2, 2));
            Console.ReadKey();

        }
    }
}
