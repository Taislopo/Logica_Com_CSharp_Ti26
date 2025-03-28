using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verifique se dois números são iguais ou diferentes.
            int num1, num2;
            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write(" Digite mais um numero: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2)
    {
              Console.Write(" Esses numeros são iguais");
    }
             else
               Console.Write(" Esses numeros são diferentes");
  }









    }
    }
