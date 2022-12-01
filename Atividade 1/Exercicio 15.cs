wa	using System;
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
            double num1, num2, num3;
            Console.WriteLine("Digite os trés numeros: ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3 && num2 < num3)
            {
                Console.WriteLine("Numero maior: " + num1);
                Console.WriteLine("Segundo numero maior: " + num3);
                Console.WriteLine("Terceiro numero maior: " + num2);
            }
            if (num1 > num2 && num1 > num3 && num3 < num2)
            {
                Console.WriteLine("Numero maior: " + num1);
                Console.WriteLine("Segundo numero maior: " + num2);
                Console.WriteLine("Terceiro numero maior: " + num3);
            }
            else if (num2 > num1 && num2 > num3 && num3 < num1)
            {
                Console.WriteLine("Numero maior: " + num2);
                Console.WriteLine("Segundo numero maior: " + num1);
                Console.WriteLine("Terceiro numero maior: " + num3);
            }
            else if (num2 > num1 && num2 > num3 && num1 < num3)
            {
                Console.WriteLine("Numero maior: " + num2);
                Console.WriteLine("Segundo numero maior: " + num3);
                Console.WriteLine("Terceiro numero maior: " + num1);
            }
            else if (num3 > num2 && num3 > num1 && num1 < num2)
            {
                Console.WriteLine("Numero maior: " + num3);
                Console.WriteLine("Segundo numero maior: " + num2);
                Console.WriteLine("Terceiro numero maior: " + num1);
            }
            else if (num3 > num2 && num3 > num1 && num2 < num1)
            {
                Console.WriteLine("Numero maior: " + num3);
                Console.WriteLine("Segundo numero maior: " + num1);
                Console.WriteLine("Terceiro numero maior: " + num2);
            }
            else if (num1 == num2 && num1 == num3 && num2 == num3 && num2 == num1 && num3 == num1 && num3 == num1)
            {
                Console.WriteLine("Os três numeros são iguais");
            }
        }
    }
}
