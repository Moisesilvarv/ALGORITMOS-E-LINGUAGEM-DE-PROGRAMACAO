using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            double ful = 0, cic = 0, bran = 0, nul = 0, i = 0, lid = 0;

            while (i != 10)
            {

                Console.WriteLine("1 Fulano");
                Console.WriteLine("2 Ciclano");
                Console.WriteLine("3 Em branco");
                Console.WriteLine("4 Voto nulo");
                Console.WriteLine("\nDigite sua opção:");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Voto em Fulano");
                        ful++;
                        break;
                    case "2":
                        Console.WriteLine("Voto em Ciclano");
                        cic++;
                        break;
                    case "3":
                        Console.WriteLine("Voto em branco");
                        bran++;
                        break;
                    case "4":
                        Console.WriteLine("Voto Nulo");
                        nul++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                i++;
            }
            lid = ful + cic + bran + nul;
            Console.WriteLine("Total de votos em Fulano: " + ful);
            Console.WriteLine("Total de votos em Ciclano: " + cic);
            Console.WriteLine("Total de votos em Branco: " + bran);
            Console.WriteLine("Total de votos Nulo: " + nul);
            Console.WriteLine("Votos Lidos: " + lid);

            if (ful > cic)
            {
                Console.WriteLine("O candidato vencedor é: Fulano!");
            }
            else
            {
                Console.WriteLine("O candidato vencedor é: Ciclano!");
            }
        }
    }
}

