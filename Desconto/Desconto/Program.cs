using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrário,
            //o desconto é de 5%. Dado o preço, calcule o valor do desconto programa

            double valor, desconto1;


            Console.Write(" Digite um valor: ");
            valor = double.Parse(Console.ReadLine());
            if(valor >= 100)
  {
             desconto1 = valor * 0.1;
             Console.Write(" Você recebeu um desconto de 10% que é " + desconto1);
  }
            else
   {
               desconto1 = valor * 0.05;
               Console.Write("Você recebeu um desconto de 5% que é " + desconto1);
   }
        }
    }
    }

