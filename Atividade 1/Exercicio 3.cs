﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIAVEIS //
            string nome;
            double salariof, vendas, salariom;

            Console.WriteLine("Digite o seu nome: ");
            nome = (Console.ReadLine());

            Console.WriteLine("Digite o seu salario fixo: ");
            salariof = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite suas vendas: ");
            vendas = double.Parse(Console.ReadLine());

            salariom = salariof + vendas * 0.20;

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu salario fixo : " + salariof);
            Console.WriteLine("Seu salario final mais comissão: " + salariom);
        }
    }
}
