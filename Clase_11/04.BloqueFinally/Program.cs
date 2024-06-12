using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bloque_finally
{
    public class Program
    {
        static void Main(string[] args)
        {
            BloqueFinally();
            Console.ReadKey();

        }

        public static void BloqueFinally()
        {
            int[] array = { 19, 0, 75, 51 };

            try
            {
                var conexion = true;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] / array[i + 1]);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Ocurrio una excepcion : {0}", exception.Message);
            }
            finally
            {

            }
        }
    }
}
