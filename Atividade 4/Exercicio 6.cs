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
            // ATIVIDADE 4: EXERCICIO 6!

            int[] a = new int[10];

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Digite os valores: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("Inverso: " + a[i]);
            }


        }
    }
}
