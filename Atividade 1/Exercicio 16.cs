﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, nota;

            Console.WriteLine("Digite suas quatro notas:");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());
            num4 = double.Parse(Console.ReadLine());

            nota = (num1 + num2 + num3 + num4) / 4;

            if (nota >= 5)
            {
                Console.WriteLine("Parabéns, Você foi aprovado!");
                Console.WriteLine("Sua nota é " + nota);
            }
            else
            {
                Console.WriteLine("Que pena, Você foi reprovado!");
                Console.WriteLine("Sua nota é " + nota);
            }

        }
    }
}
