using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucessão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, soma, menos;

            Console.Write(" Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            menos = num1 - 1;
            soma = num1 + 1;
            Console.WriteLine(" o antecessesor do numero " + num1 + " é o " + menos + " e o sucessor é o " + soma);




        }
    }
}
