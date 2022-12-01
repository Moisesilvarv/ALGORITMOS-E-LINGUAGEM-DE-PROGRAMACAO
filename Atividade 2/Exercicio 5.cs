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
            int[] v = new int[10]; int[] r = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Digite um valor: ");
                v[i] = int.Parse(Console.ReadLine());
                r[i] = v[i] * 2;
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Quadrado dos numeros do Vetor V: " + r[i]);
            }
        }
    }
}
