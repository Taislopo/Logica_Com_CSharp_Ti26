using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double ano;
            //Determine se um ano é bissexto.
            //Um ano é bissexto se for divisível por 4, mas não por 100, a não ser que seja divisível por 400.
            Console.Write("digite seu ano  ");
              ano = double.Parse(Console.ReadLine());    
              if(ano % 4 == 0 && ano % 100 == 0 && ano % 400 == 0)
                {
                Console.Write("é bissexto");
     }
               else{
                    Console.Write("não é bissexto");
     }








        }
    }
}
