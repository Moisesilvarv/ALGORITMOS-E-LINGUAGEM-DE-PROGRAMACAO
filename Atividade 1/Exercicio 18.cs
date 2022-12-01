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
            int num1, num2, diferença;

            Console.WriteLine("Digite seu dois numeros inteiros: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            diferença = (num1 - num2);

            Console.WriteLine("A diferença entre os dois numeros é: " + diferença + " numeros ");
        }
    }
}
