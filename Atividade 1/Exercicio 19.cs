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
            Console.WriteLine("Aperte a tecla ENTER para a repetição dos numeros!");
            Console.ReadLine();
            int num1 = 100;

            while (num1 > 0)
            {
                Console.WriteLine(num1.ToString());
                num1--;
            }
        }
    }
}
