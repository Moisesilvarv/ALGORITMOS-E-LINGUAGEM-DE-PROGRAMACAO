﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            double cheque = 0, cartao = 0, cedula = 0, i = 0, soma = 0;

            while (i != 150)
            {

                Console.WriteLine("1 CHEQUE");
                Console.WriteLine("2 CARTAO");
                Console.WriteLine("3 CEDULA");
                Console.WriteLine("\nDigite sua opção:");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cheque");
                        Console.WriteLine("Digite o valor: ");
                        cheque = double.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Cartao");
                        Console.WriteLine("Digite o valor: ");
                        cartao = double.Parse(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Cedula");
                        Console.WriteLine("Digite o valor: ");
                        cedula = double.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.ReadKey();
                i++;
            }
            soma = cheque + cartao + cedula;
            Console.WriteLine("A receita da noite é: " + soma);
        }
    }
}

