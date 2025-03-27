using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faixa_de_Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;


            Console.Write(" Digite um numero: ");
            num1 = int.Parse(Console.ReadLine()); 
            if( num1 > 20  &&  num1 < 90)
       {
               Console.Write(" esse numero está compreendido na faixa de valores de 20 a 90 ");
                    }
             else
       {        Console.Write(" Esse numero não está compreendido na faixa de valores ");
                    }
            










        }
    }
}
