using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;


            Console.Write(" Qual é a sua idade? ");
            idade = int.Parse(Console.ReadLine());


            if (idade < 16) ;
     {
                Console.Write(" NÃO ELEITOR ");
       }
           else
       if(idade >= 16 e idade < 18 ou idade >= 65);
      {
                Console.Write("ELEITOR FACULTATIVO");
      }
            else
       if(idade >= 18 e idade < 65)
     {
                Console.Write("ELEITOR OBRIGATORIO");







        }
    }
}
