using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_PARA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Escreva um programa que leia um conjunto de 20 números inteiros e mostre qual foi o maior valor fornecido pelo 
            //usuário.

            int contador, numero, maior;

           
            maior = 1;
            for (contador = 0; contador < 21; contador++)
            {
                {
                    Console.Write(" Digite um numero: ");
                    numero = int.Parse(Console.ReadLine());
                    contador = contador + 1;
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                }
            }
                Console.WriteLine("O maior numero digitado é " + maior);











            

        }
    }
}
