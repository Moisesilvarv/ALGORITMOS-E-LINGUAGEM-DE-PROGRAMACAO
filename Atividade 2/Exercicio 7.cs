﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[6];


            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Digite um valor: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("Valor inverso: " + v[i]);
            }
        }
    }
}
