using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _26_ListaNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List <string>();
            bool sair = false;
            
            do
            {
                Console.Clear();
                System.Console.WriteLine("===================");
                System.Console.WriteLine("  Adicionar nomes  ");
                System.Console.WriteLine("===================");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Adicionar nome");
                System.Console.WriteLine("2 - Sair");
                int opcao = int.Parse(Console.ReadLine());
                System.Console.WriteLine();
                System.Console.WriteLine($"Há {lista.Count} nomes salvos");

                switch (opcao)
                {
                    case 1:
                    System.Console.Write("Digite o nome: ");
                    string nome = Console.ReadLine();
                    lista.Add(nome);
                    break;

                    case 2:
                    sair = true;
                    break;
                    
                }
            } while (!sair);
        }
    }
}
