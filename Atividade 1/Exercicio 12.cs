using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 >= 100 && num1 <= 200)
            {
                Console.WriteLine("O numero está no intervalo entre os dois numeros");
            }
            else
            {
                Console.WriteLine("O numero não está no intervalo entre os dois numeros");
            }
        }
    }
}
