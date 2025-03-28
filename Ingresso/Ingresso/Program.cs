using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingresso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verifique se o valor total de uma compra de ingressos é superior a 200 reais. 
            //Se for, o cliente tem direito a um desconto de 10%. Calcule o valor total com ou sem o desconto.

            double ingresso, desconto, valor;
            Console.Write(" Qual o valor do ingresso? ");
            ingresso = int.Parse(Console.ReadLine());
            if (ingresso >= 200)
            {
                desconto = ingresso * 0.1;
                valor = ingresso - desconto;


                Console.Write(" O valor do ingresso com o desconto é " + valor);
            }
            else


                Console.Write(" Não tem desconto então o valor do ingresso é " + ingresso);


  }




    }
    }

