﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("Os dois valores são iguais");
            }
            else if (valor1 > valor2)
            {
                Console.WriteLine("O " + valor1 + " é maior: ");
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine("O " + valor2 + " é maior: ");
            }


        }
    }
}
