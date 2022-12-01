using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] v = new int[10];


            for (int i = 0; i < 10; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            M(ref v);


        }
        public static void M(ref int[] x)
        {
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                if (x[i] % 2 == 1)
                {
                    a += x[i];
                }


            }
            Console.WriteLine("A soma dos numeros impar é: " + a);
        }
    }
}