using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double temperatura;
            Console.Write("Digite a temperatura em graus Celsius: ");
            temperatura = double.Parse(Console.ReadLine());    

            if (temperatura < 15) {
               Console.WriteLine("Frio ");
    }
             else if(temperatura >= 15 && temperatura <= 25) {
                 Console.WriteLine("Ameno ");
            }
              else {
                  Console.WriteLine("Quente ");
            }














        }
    }
}
