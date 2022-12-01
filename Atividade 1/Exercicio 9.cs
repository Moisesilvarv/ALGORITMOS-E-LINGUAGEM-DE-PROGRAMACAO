using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIAVEIS //
            int num1, num2;

            // WRITE //

            Console.WriteLine("Digite seu numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            // PARTE LOGICA //

            if (num1 > num2)
            {
                Console.WriteLine("O numero maior é o: " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("O numero maior é o: " + num2);
            }
            else if (num1 == num2 || num2 == num1)
            {
                Console.WriteLine("O dois numeros são iguais");
            }

        }
    }
}
