using System;
using System.Collections.Generic;
using System.Linq;

namespace Manejo_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string> { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            List<string> removeColors = new List<string> { "RED", "WHITE", "BLUE" };


            Console.WriteLine("List: ");
            foreach(string color in colors)
            {
                Console.Write(color+ " ");
            }


            var listaAux = colors.Except(removeColors).ToList();
            colors.Clear();
            colors.AddRange(listaAux);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lista después del removeColors: ");
            foreach (string color in colors)
            {
                Console.Write(color + " ");
            }
            Console.WriteLine();
        } 
    }
}
