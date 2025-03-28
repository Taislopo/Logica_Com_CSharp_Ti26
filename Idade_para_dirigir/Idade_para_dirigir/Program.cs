using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_para_dirigir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verifique se uma pessoa tem idade suficiente para obter a carteira de motorista,
            //considerando que a idade mínima é 18 anos.

            int idade;
            Console.Write(" Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if(idade >= 18)
     {
                Console.Write(" Tem idade para dirigir");
     }
                else
     {
                Console.Write(" Não tem idade para dirigir ");
     }









        }
    }
}
