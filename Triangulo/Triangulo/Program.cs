using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Double lado1, lado2, lado3;

            Console.WriteLine ("Digite o primeiro lado do triângulo: ");
            lado1 =  Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado do triângulo: ");
            lado2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            lado3 = Double.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1) {
                if(lado1 == lado2 && lado2 == lado3) {
                    Console.WriteLine("O triagulo chama Equilátero");
                }
               else(lado1 == lado2 && lado1 == lado3 && lado2 == lado3) {
                    
                    Console.WriteLine("O triagulo chama Isósceles");
                }
                else {
                    Console.WriteLine("O triagulo chama Escaleno");
                }
            }
            else {
                Console.WriteLine("Os valores fornecidos não formam um triângulo válido.");
            }













        }
    }
}
