using System;
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
            // Faça um programa que leia um vetor de 10 posições e verifique se existem valores.
            // iguais e os escreva na tela.

            int[] v = new int[10];


            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Olá, Digite os dez valores!");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 9; i++)
            {
                for (int g = i + 1; g < 10; g++)
                {
                    if (g != i && v[g] == v[i])
                    {
                        Console.WriteLine("numeros repetidos  " + v[g]);
                    }
                }
            }
        }
    }
}
