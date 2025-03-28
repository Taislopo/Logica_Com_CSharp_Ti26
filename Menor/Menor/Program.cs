using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;

            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite ultima numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1<num3)
     {
               Console.Write(" o numero menor é " + num1);
     }
           else if(num2 > num1 && num2  > num3)
     {
                Console.Write(" o numero menor é " + num2);
     }
            else
      {
                Console.Write(" o numero menor é " + num3);
      }
        }








    }
    }
