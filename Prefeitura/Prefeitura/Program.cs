using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, prestacao, limite;

            Console.Write(" Qual é o seu salario? ");
            salario = double.Parse(Console.ReadLine());
            Console.Write(" Qual é o valor da prestação? ");
            prestacao = Double.Parse(Console.ReadLine());
            limite = salario * 0.30;
            if(prestacao >= limite)
    {
                Console.Write(" O emprestimo não poderá ser concedido ");
                    }
            else
    {
                Console.Write(" O emprestimo será concendido ");
                    }











        }
    }
}
