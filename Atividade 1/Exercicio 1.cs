﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIAVEIS //
            double area, altura, base1;


            // WRITE //

            Console.WriteLine("Digite a altura do triangulo: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do triangulo: ");
            base1 = double.Parse(Console.ReadLine());
            area = base1 * altura / 2;
            Console.WriteLine("O resultado é: " + area);
        }
    }
}
