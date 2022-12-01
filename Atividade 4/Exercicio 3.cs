using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {

            // NOME: MOISES DA SILVA PIMENTA 
            // 315-01AM - ALGORITMOS E LINGUAGEM DE PROGRAMAÇÃO 
            // ATIVIDADE 4: EXERCICIO 3!

            int[] q = new int[10];

            int maior = 0, pos_mai = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Digite os valores: ");
                q[i] = int.Parse(Console.ReadLine());
                if (q[i] < 0)
                {
                    Console.WriteLine("Valor inesperado. Apenas numeros positivos!");
                    Environment.Exit(0);
                }
                else if (q[i] > maior)
                {
                    maior = q[i];
                    pos_mai = i;
                }
            }
            Console.WriteLine("Valor do maior elemento: " + maior);
            Console.WriteLine("Posição do maior elemento: " + pos_mai);
        }
    }
}
