using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string senhaUsuario, digito;
            
            true senhaValida = falso;

            Console.WriteLine("Digite a senha: ");

            senhaUsuario = int.Parse(Console.ReadLine());


            int tamanhoSenha = tx.numero_caracteres(senhaUsuario);


             if(tamanhoSenha < 8)

     {

                Console.WriteLine("Por favor a senha deve ter 8 caracteres, tente novamente !");

     }

               else

     {

                for(inteiro i = 0; i < tamanhoSenha; i++)

        {

                    digito = tx.obter_caracter(senhaUsuario, i);

               if(digito == "0" && digito == "1" && digito == "2" && digito == "3" && digito == "4" && digito == "5" && digito == "6" && digito == "7" && digito == "8" && digito == "9")

            {

                    Console.WriteLine(("senha valida");

                    senhaValida = verdadeiro;

               

            }

                }

                if (senhaValida == falso){
                    Console.WriteLine(("Senha invalida");
                        }

            }

        }














    }
    

