using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace KENO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritmo para verificar se o Keno possui uma perna mais curta que a outra, peça a medida exata 
            //de cada perna e verifique a metragem exibindo as seguintes possibilidades de mensagem: 
            //Cotó na perna esquerda, cotó na perna direita ou normal.


            Double tam1, tam2;

            Console.Write(" Qual o tamanho da perna direita? ");
            tam1 = int.Parse(Console.ReadLine());
            Console.Write(" Qual o tamanho da perna esquerda? ");
            tam2 = int.Parse(Console.ReadLine());
            if(tam1 > tam2)
     {
                Console.Write("Cotó na perna esquerda ");
     }
            else
               if(tam1 == tam2)
      {
                Console.Write(" NORMAL");
      }
            else
             if (tam1<tam2)
            {
                Console.Write(" Cotó na perna direita");
             }

        }








    }
    }

