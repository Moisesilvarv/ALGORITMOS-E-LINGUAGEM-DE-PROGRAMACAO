﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {

            // NOME: MOISES DA SILVA PIMENTA 
            // 315-01AM - ALGORITMOS E LINGUAGEM DE PROGRAMAÇÃO 
            // ATIVIDADE 4: EXERCICIO 2!


            double[] v = new double[10];
            double media = 0, soma = 0;
            int o = 0;
            for (int i = 0; i <= 9; i++)

            {
                Console.WriteLine("Digite a media dos alunos: ");
                v[i] = double.Parse(Console.ReadLine());
                soma = v[i] + soma;
                media = soma / 10;
            }
            for (int i = 1; i <= 1; i++)
            {
                Console.WriteLine("Media é " + media);
            }

            for (; o <= media;)
            {
                o++;
            }
            Console.WriteLine("Alunos acima da media: " + o);
            Console.WriteLine("Resultado da contagem: " + soma);
        }
    }
}