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
            int n1, n2, n3;
            double media;
            string nome;

            Console.WriteLine("Qual é o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite suas trés notas: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3);

            if (media / 3 > 10)
            {
                media = 10;
                Console.WriteLine("Olá, " + nome + "! sua média aritimética é  " + media + ".");
            }
            else
            {
                media = (n1 + n2 + n3) / 3;
                Console.WriteLine("Olá, " + nome + "! sua média aritimética é  " + media + ".");
            }
        }
    }
}
