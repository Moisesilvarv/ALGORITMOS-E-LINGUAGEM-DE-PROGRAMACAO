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
            int[] v = new int[8]; double soma = 0;


            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("Digite um valor: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            soma = v[1] + v[3];
            Console.WriteLine("A soma das posicôes é: " + soma);
        }
    }
}
