﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] v = new int[10];


            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Olá, Digite os dez valores!");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 9; i++)
            {
                if (v[i] < 0)
                {
                    v[i] = 0;
                }
                Console.WriteLine("Abaixo de 0: " + v[i]);
            }
        }
    }
}
