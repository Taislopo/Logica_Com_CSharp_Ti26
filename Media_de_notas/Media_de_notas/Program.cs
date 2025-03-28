using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcule a média de quatro notas e determine se o aluno foi aprovado ou reprovado.
            //Considera-se aprovado quem tem média maior ou igual a 7 programa

            double nota1, nota2, nota3, nota4, media;
            Console.Write("Digite primeira nota: ");
            nota1 = int.Parse(Console.ReadLine);
            Console.Write(" Digite segunda nota: ");
            nota2 = int.Parse(Console.ReadLine);
            Console.Write(" Digite terceira nota: ");
            nota3 = int.Parse(Console.ReadLine);
            Console.Write(" Digite quarta nota: ");
            nota4 = int.Parse(Console.ReadLine);
            media = (nota1 + nota2 + nota3 + nota4) / 4)
            if (media >= 7)
            {
                Console.Write("Aluno foi aprovado com a nota " + media);
            }
            else
                Console.Write(" Aluno foi reprovado com a nota " + media);
                               

  }

    }
    }

