using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Idade
{
    internal class Program
    {                   
        static void Main(string[] args)
        {
            int ano_nascimento, ano_atual, idade;
            // int; inteiro
              Console.Write("Digite seu ano de nascimento: ");
              // Console.Write: escreva \ Console.WriteLine: escreval
              ano_nascimento = int.Parse(Console.ReadLine());
              // int.Parse(Console.ReadLine()); leia a variavel inteiro
              Console.Write("Digite o ano atual: ");
              ano_atual = int.Parse(Console.ReadLine());
              idade = ano_atual - ano_nascimento;
              Console.Write(" Sua idade é " + idade);
















        }
    }
}
