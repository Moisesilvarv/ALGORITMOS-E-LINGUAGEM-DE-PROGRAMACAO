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
            double C, F;
            Console.WriteLine("Qual é a temperatura hoje: ");
            Console.Write('°');
            C = double.Parse(Console.ReadLine());
            F = (9 * C + 160) / 5;
            Console.WriteLine("A conversão da temperatura em Celsius Para Fahrenheit é: " + F + "°");
        }
    }
}
