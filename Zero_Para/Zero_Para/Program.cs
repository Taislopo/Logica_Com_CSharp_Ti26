using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero_Para
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Programa que pergunte sua idade e responda o ano que você
            //nasceu. O programa deverá permanecer perguntando idades
            //até que o usuário digite como a idade o número 0 (zero)


            int contador, idade;

           for(contador=0; contador <= 99; contador++)
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade == 0)
                {
                    contador = contador + 100;
                }
            }













        }
    }
}
