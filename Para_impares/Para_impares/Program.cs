using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mostre somente os números ímpares de 1 a 100.

            int contador;
            
          
           for(contador = 1; contador <= 100; contador++)
    {
                Console.WriteLine("COTANDO.." + contador);
                contador = contador + 2;
    }



        }
    }
}
