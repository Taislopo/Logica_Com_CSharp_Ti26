﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinhos_PARA
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 	Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como dados de 
            //entrada tipos de vinho, sendo: "t" para tinto e "b" para branco. Como a quantidade de vinhos é desconhecida, 
            //utilize a letra "f" para finalizar.Após finalizar o programa deve mostrar a quantidade de cada vinho na adega.



            int contador, quantidadeBranco = 0, quantidadeTinto = 0;
            char vinhos;


            for (contador = 1; contador > 0; contador++)
            {
                Console.Write("Digite qual o tipo de vinho ou digite 'f' para finalizar o programa \n Digite ('t' para vinho tinto e 'b' para vinho branco): ");
                vinhos = Console.ReadLine();


                if (vinhos = 'b')
                {
                    quantidadeBranco = quantidadeBranco + 1;
                }
                if (vinhos = 't')
                {
                    quantidadeTinto = quantidadeTinto + 1;
                }

                if (vinhos = 'f')
                {
                    Console.WriteLine("O total de vinhos brancos em estoque são: ", quantidadeBranco, "\ne o de vinhos tintos são: ", quantidadeTinto);

                }






            }
        }
    }
}
