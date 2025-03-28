using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adinhacao_enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {//5)	Simular o jogo de adivinhação: o jogador 1 escolhe um número entre 1 e 10; o jogador 2 insere números na tentativa de acertar o número 
         //escolhido pelo jogador 1. Quando ele acertar, o algoritmo deve informar que ele acertou o número x (escolhido pelo jogador 1) em x tentativas 
         //(quantidade de tentativas do jogador 2).

            int numero, acertos, contador, advin;
            contador = 0;
            acertos = 0;
            Console.Write("\n JOGADOR 1 Digite um numero de 1 a 10 \n");
            numero = int.Parse(Console.ReadLine());
    
            while(contador < 11)
    {
                Console.WriteLine(" JOGADOR 2 Adivinhe o numero escolhido \n");
                advin = int.Parse(Console.ReadLine());
                contador = contador + 1;
                if (advin == numero)
                {
                    acertos = acertos + 1;
                }
                   Console.WriteLine(" VOCÊ ACERTOU O NUMERO " + advin + " NA TENTATIVA " + "contador +");
    }

               }

            }
    }
}
