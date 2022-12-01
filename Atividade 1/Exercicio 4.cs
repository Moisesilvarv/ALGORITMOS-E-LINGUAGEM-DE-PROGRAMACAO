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
            string nome;
            double n1, n2, n3, media, peso1, peso2, peso3;

            Console.WriteLine("Qual seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual suas três notas: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());


            peso1 = 0.2; peso2 = 0.4; peso3 = 0.6;
            media = (n1 + n2 + n3 * peso1 * peso2 * peso3 / 3);

            if (media > 10)
            {
                media = 10;
            }



            Console.WriteLine("Seu nome é " + nome + " e sua média é: " + media);
        }
    }
}
