using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasNoGenericas
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList miArrayList = new ArrayList();

            // Se agregar diferentes tipos de elementos al ArrayList
            miArrayList.Add("Hola");             
            miArrayList.Add(10);                    
            miArrayList.Add(3.14);                 
            miArrayList.Add(true);                 
            miArrayList.Add(new DateTime(2022, 4, 25)); 
            miArrayList.Add(new Mascota("Pedrito",3,"Perro"));

            // Mostrar los elementos del ArrayList
            Console.WriteLine("Elementos del ArrayList:");
            foreach (var item in miArrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
