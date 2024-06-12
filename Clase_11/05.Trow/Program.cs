using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Trow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Throw();
            Throw();
            Throw();
            Throw();
            Console.ReadKey();
        }

        public static void Throw()
        {
            int[] array = { 19, 0, 75, 51 };

            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] / array[i + 1]);
                }
            }
            catch (DivideByZeroException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Ocurrio un error", e);
            }
            finally
            {
                Console.WriteLine("Mensaje");
            }
        }
    }
}
