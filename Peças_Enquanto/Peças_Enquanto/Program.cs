using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Peças_Enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4) Uma fábrica tem uma linha de produção capaz de produzir 400 peças / dia.Um funcionário controla a qualidade, 
            //  cadastrando o número da peça e o seu estado(aprovado ou reprovado). Criar um programa para cadastrar o 
            //  controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.


            int contador = 1, reprovado, aprovado, estado;
            aprovado = 0;
            reprovado = 0;
            while(contador < 401)
    {
                Console.WriteLine("Peça: " + contador);
                Console.WriteLine("digite(1)APROVADO e (2)REPROVADO: ");
                estado = int.Parse(Console.ReadLine());
                contador = contador + 1;
             if(estado == 1)
    {
                    aprovado = aprovado + 1;
    }
                else if (estado== 2){
                    reprovado = reprovado + 1;
                }
                else{
                    Console.WriteLine(" Estado invalido digite numero 1 ou 2");
                    contador = contador - 1;
    }
            }
             Console.WriteLine(" Aprovados: " + aprovado + " Reprovados: " + reprovado);







        }
    }
}
