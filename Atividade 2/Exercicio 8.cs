using System;
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
            int[] v = new int[15]; double media = 0, soma = 0;



            for (int i = 0; i <= 14; i++)
            {
                Console.WriteLine("Digite sua nota!");
                v[i] = int.Parse(Console.ReadLine());
                soma = v[i] + soma;


            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Soma geral da sala:: " + soma);
                media = soma / 15;
                Console.WriteLine("Media geral da sala: " + media);
            }
        }
    }
}
