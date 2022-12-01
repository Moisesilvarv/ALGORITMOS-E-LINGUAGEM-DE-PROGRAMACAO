using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite o valor: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 200 && numero <= 300)
            {
                Console.WriteLine("O numero esta no intervalo entre os dois numeros");
            }
            else if (numero < 200 || numero > 300)
            {
                Console.WriteLine("O numero não esta no intervalo entre os dois numeros");
            }
        }

    }
}
