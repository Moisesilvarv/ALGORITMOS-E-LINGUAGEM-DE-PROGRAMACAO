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
            F = double.Parse(Console.ReadLine());
            C = ((F - 32) * 5) / 9;
            Console.WriteLine("A conversão da temperatura em Fahrenheit Para Celsius é: " + C + "°");
        }
    }
}
