﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_enquantoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;

            while (contador <= 100)
            {
                if (contador % 2 == 0)
                {

                    Console.WriteLine(contador);

            }
                contador++;

            }
        }
    }
}
