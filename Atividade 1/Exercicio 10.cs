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
            double num1;
            Console.WriteLine("Digite o numero: ");
            num1 = double.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("O " + num1 + " é par");
            }
            else
            {
                Console.WriteLine("O " + num1 + " é impar");
            }
        }
    }
}
