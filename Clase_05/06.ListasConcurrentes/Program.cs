using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListasConcurrentes
{
    public class Program
    {
        static void Main(string[] args)
        { 

            BlockingCollection<Emoji> emojis = new BlockingCollection<Emoji>();

            for (int i = 0; i < 5; i++)
            {
                emojis.Add(new Emoji($"Emoji{i}", ":)"));
                System.Threading.Thread.Sleep(1000); // esperar 1 segundo
            }
            emojis.CompleteAdding(); // Indicar que no se agregaran mas elementos

            // Consumir emojis del BlockingCollection
            foreach (var emoji in emojis.GetConsumingEnumerable())
            {
                Console.WriteLine($"Emoji recibido: {emoji.Mostrar()}");
            }

            Console.ReadLine(); // Esperar antes de salir
        }
    }
}
