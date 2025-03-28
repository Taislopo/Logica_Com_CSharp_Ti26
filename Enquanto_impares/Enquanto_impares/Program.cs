using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enquanto_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Mostre somente os números ímpares de 1 a 100.

            int contador;

            contador = 1;
            
            while (contador <101)
            {
                Console.WriteLine("COTANDO.." + contador);
                contador = contador + 2;
            }

        }
    }
}
