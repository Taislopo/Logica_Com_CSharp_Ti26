using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Digite um numero: ");
    num = int.Parse(Console.ReadLine());
               if(num % 3 == 0 && num == num % 5 == 0)
    {
                Console.WriteLine(" Esse numero é multiplo de 3 ou de 5");
    }
            else
    {
                Console.WriteLine((" Esse numero não é multiplo de 3 ou 5");
    }

        }










    }
    }

