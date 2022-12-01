using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIAVEIS //
            int idade1;
            string nome;

            // WRITE //

            Console.WriteLine("Qual é a sua nome: ");
            nome = (Console.ReadLine());

            Console.WriteLine("Qual é a sua idade: ");
            idade1 = int.Parse(Console.ReadLine());

            // PARTE LOGICA //

            if (idade1 <= 13)
            {
                Console.WriteLine(nome + ", você é um jogador infantil");
            }
            else if (idade1 == 14 || idade1 < 17)
            {
                Console.WriteLine(nome + ", você é um jogador juvenil");
            }
            else if (idade1 >= 17)
            {
                Console.WriteLine(nome + ", você é um jogador senior");
            }
        }
    }
}
