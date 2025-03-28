using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faixa_de_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Dado um número, verifique se ele está na faixa de 1 a 10, 11 a 20
            //ou acima de 20 programa
            int num;
            Console.Write(" Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            if(num > 0 && num < 11)
    {
                Console.Write(" O numero está na faixa de 1 a 10 ");
    }
           else        if (num> 10 && num<20)
                Console.WriteLine(" O numero está na faixa de 11 a 20 ");
            else
                Console.WriteLine(" O numero está acima de 20 ");











        }
    }
}
