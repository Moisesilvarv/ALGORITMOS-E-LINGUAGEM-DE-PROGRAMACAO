﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIAVEIS //
            double num1, num2, soma, div, multi, sub;

            // WRITE E READ // 

            Console.WriteLine("Digite o numero 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2: ");
            num2 = double.Parse(Console.ReadLine());


            // RESULTADOS //

            soma = num1 + num2;
            div = num1 / num2;
            multi = num1 * num2;
            sub = num1 - num2;

            Console.WriteLine("A soma do numero um com o numero dois é: " + soma);
            Console.WriteLine("A divisão do numero um com o numero dois é: " + div);
            Console.WriteLine("A multiplicação do numero um com o numero dois é: " + multi);
            Console.WriteLine("A subtração do numero um com o numero dois é: " + sub);

        }
    }
}
