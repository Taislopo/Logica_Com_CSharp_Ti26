using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positivo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.Write(" Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            if(num < 0)
    {
                Console.WriteLine(" Esse numero é negativo ");
  }
           else
    {
                Console.WriteLine(" Esse numero é positivo ");
    }
        }
    }
    }

