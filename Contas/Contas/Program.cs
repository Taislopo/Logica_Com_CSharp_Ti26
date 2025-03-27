using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, div, soma, subs, multi;


             Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            num2 = int.Parse(Console.ReadLine());
            div = num1 / num2;
            soma = num1 + num2;
            subs = num1 - num2;
            multi = num1 * num2;
            Console.WriteLine(" A soma desses dois numeros é " + soma);
            Console.WriteLine(" A multiplicação desses dois numeros é " + multi);
            Console.WriteLine(" A subtração desses dois numeros é " + subs);
            Console.WriteLine(" A divisão desses dois numeros é " + div);













        }
    }
}
