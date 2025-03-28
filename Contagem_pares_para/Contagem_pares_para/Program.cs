using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem_pares_para
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pares, contagem;
            pares = 0;
            for(contagem = -2; contagem <= 98; contagem++)
    {
               pares = pares  + 2;
                Console.WriteLine("Numeros pares " + pares);
    }

        }


    }
}
