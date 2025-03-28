using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinhação_para
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int numero, acertos, contador, advin;
          
                acertos = 0;
                Console.Write("\n JOGADOR 1 Digite um numero de 1 a 10 \n");
                numero = int.Parse(Console.ReadLine());

                for (contador=0; contador <= 21; contador++)
                {
                    Console.Write(" JOGADOR 2 Adivinhe o numero escolhido \n");
                    advin = int.Parse(Console.ReadLine());
                    contador = contador + 1;
                    if (advin == numero) ;
                    {
                        acertos = acertos + 1;

                    }
                    Console.Write(" VOCÊ ACERTOU O NUMERO " + advin + " NA TENTATIVA " + contador);
                }

            }
        }
    }
}
