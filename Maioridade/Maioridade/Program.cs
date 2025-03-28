using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maioridade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determine se uma pessoa atingiu a maioridade penal, que ocorre aos 18 anos no Brasil.

            int idade;
            Console.Write(" Digite sua idade: ");
            idade= int.Parse(Console.ReadLine());
            if(idade >= 18)
     {
                Console.Write(" Maior de idade penal");
     }
            else
     {
                Console.Write(" Menor de idade penal ");
     }
        }








    }
    }

