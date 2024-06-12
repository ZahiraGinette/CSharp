using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Multiples_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplesCatch();
            Console.ReadLine();
        }

        public static void MultiplesCatch()
        {
            int[] array = { 19, 0, 75, 52 };

            try
            { 
                //for(int i = 8; i < array.Length; i++)
                //{
                //    Console.WriteLine(array[i] / array[i + 1]);
                //}

                // provoca un IndexOutOfRangeException
                //Console.WriteLine(array[9]);

                // provoca un DivideByZeroException
                // int result = array[0] / array[1];

                // provoca un ArgumentOutOfRangeException
                int index = -1;
                int value = array[index];
                // Me coinecto a mi base de datos

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Ocurrio una excepcion : {0}", exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Ocurrio una excepcion : {0}", exception.Message);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("Ocurrio una excepcion : {0}", exception.Message);
            }
            catch (EncoderFallbackException exception)
            {
                Console.WriteLine("Ocurrio una excepcion : {0}", exception.Message);
            }
            catch (Exception exception)
            {
                //Console.WriteLine("Primera vez que salto error");
                //try
                //{
                //    int[] arrayDos = { 1, 2 };
                //    Console.WriteLine(arrayDos[4]);
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //} 
            }
            
        }
    }
}
