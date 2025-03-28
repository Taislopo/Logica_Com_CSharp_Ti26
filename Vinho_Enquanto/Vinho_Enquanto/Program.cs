using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinho_Enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int qtdVinhoTinto = 0, qtdVinhoBranco = 0;
            string tipoVinho;

            while (tipoVinho != "f") 
    {
                Console.Write("Digite o tipo do vinho (t - tinto / b - branco): ");
                tipoVinho = Console.ReadLine();


                if(tipoVinho == "t")
      {
                    qtdVinhoTinto++;
      }
               else
      {
                    qtdVinhoBranco++;
      }
            }

            Console.Write("Quantidade de vinho branco: " + qtdVinhoBranco );
            Console.Write("Quantidade de vinho tinto: " + qtdVinhoTinto);














        }
    }
}
