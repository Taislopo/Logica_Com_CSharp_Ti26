using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagem_pares_enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int contagem;

            contagem = 0;
            while(contagem<100)
            {
               contagem = contagem + 2;
                Console.WriteLine("Numeros pares " + contagem);
            }










        }
    }
}
