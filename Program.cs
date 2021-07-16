using System;
using System.Collections.Generic;

namespace logica
{
    class Program
    {
        static List<string> ListaNomes = new List<string>();

        static void Main(string[] args)
        {

            string pessoa;

            do
            {
                Console.WriteLine("Digite seu nome!");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade!");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 16)
                {
                    Console.WriteLine("Entrada autorizada! Bom evento");
                    ListaNomes.Add(nome);
                }
                else
                {
                    Console.WriteLine($"Você está acompanhado dos seus pais");
                    string acompanhante = Console.ReadLine().ToLower();
                    if (acompanhante == "s")
                    {
                        Console.WriteLine($"Sua entrada está autorizada!");
                        ListaNomes.Add(nome);
                    }
                    else if (acompanhante == "n")
                    {
                        Console.WriteLine($"Sua entrada não foi liberada!!!! Por favor volte ano que vem. ");

                    }
                }

                Console.WriteLine($"Deseja cadastrar mais uma pessoa? s/n");
                pessoa = Console.ReadLine();

            } while (pessoa == "s");

            MonstrarNome();
        }

        // lista
        static void MonstrarNome()
        {

            foreach (var CadaItem in ListaNomes)
            {
                Console.WriteLine($"nome {CadaItem}");

            }
        }
    }
}
