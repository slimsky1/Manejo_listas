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

            

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            var listaAux = colors.Except(removeColors).ToList();
            colors.Clear();
            colors.AddRange(listaAux);
            Console.WriteLine();
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        } 
    }
}
