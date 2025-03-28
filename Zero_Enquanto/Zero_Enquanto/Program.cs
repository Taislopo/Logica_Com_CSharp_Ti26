using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero_Enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que pergunte sua idade e responda o ano que você
            //nasceu. O programa deverá permanecer perguntando idades
            //até que o usuário digite como a idade o número 0 (zero)


            int contador, idade;
            contador = 1;
            while(contador == 1)
    {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if(idade == 0)
       {
                    contador = contador + 100;
       }
            }








        }
    }
}
