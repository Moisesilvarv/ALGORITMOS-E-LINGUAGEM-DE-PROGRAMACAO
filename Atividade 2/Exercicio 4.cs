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
            double fem = 0, masc = 0, altf = 0, i = 0, media = 0, altm = 0, media1 = 0, media2 = 0, perc = 0, r = 0;
            int iddm = 0, iddf = 0;

            while (i != 2)
            {

                Console.WriteLine("Para Masculino: 1");
                Console.WriteLine("Para Feminino: 0");
                Console.WriteLine("\nQual é o seu sexo?");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Masculino!");
                        Console.WriteLine("Digita sua idade: ");
                        iddm = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digita sua altura: ");
                        altm = double.Parse(Console.ReadLine());
                        if (iddm >= 18 && iddm <= 35)
                        {
                            perc++;
                        }
                        masc++;
                        break;
                    case "0":
                        Console.WriteLine("Feminino!");
                        Console.WriteLine("Digita sua idade: ");
                        iddf = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digita sua altura: ");
                        altf = double.Parse(Console.ReadLine());
                        if (iddf <= 18 && iddf <= 35)
                        {
                            perc++;
                        }
                        fem++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, Apenas 0 ou 1!");
                        break;
                }
                r = i * 100 / perc;
                i++;
            }

            media2 = (iddm + iddf) / i;
            media = altf / fem;
            media1 = iddm / masc;

            Console.WriteLine("A media da idade do Grupo é: " + media2);
            Console.WriteLine("A media da altura Feminina é: " + media);
            Console.WriteLine("A media da idade Masculina é: " + media1);
            Console.WriteLine("Porcentual de pessoas entre 18 e 35 anos é! " + r + "%");


        }
    }
}

