using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double folhas, preço, resultado;

            Console.WriteLine("Quantas xerox você vai querer: ");
            folhas = double.Parse(Console.ReadLine());
            preço = 0.50;

            if (folhas > 200)
            {
                preço = 0.30;
                resultado = folhas * preço;
                Console.WriteLine("O valor a ser pago é: " + resultado);
            }
            else
            {
                preço = 0.50;
                resultado = folhas * preço;
                Console.WriteLine("O valor a ser pago é: " + resultado);
            }
        }
    }
}
