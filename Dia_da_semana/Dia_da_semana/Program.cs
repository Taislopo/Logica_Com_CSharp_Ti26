using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_da_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determine se o dia informado é um dia útil ou final de semana.
            
            int dia;
            Console.Write(" Digite um número correspondente ao dia da semana ");
            dia = int.Parse(Console.ReadLine());
            if (dia == 6 && dia == 7)
            {
                Console.Write(" Final de semana ");
            }
            else
                Console.Write(" Dia de semana ");


  }
    }
    }
