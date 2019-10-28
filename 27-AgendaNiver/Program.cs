using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _27_AgendaNiver
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            Dictionary<string, DateTime> dicio = new Dictionary <string, DateTime>();

            do
            {
                Console.Clear();
                System.Console.WriteLine("==========================");
                System.Console.WriteLine("  Agenda de aniversários  ");
                System.Console.WriteLine("==========================");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Cadastrar convidado");
                System.Console.WriteLine("2 - Apagar convidado");
                System.Console.WriteLine("3 - Buscar convidado");
                System.Console.WriteLine("4 - Todos os convidados");
                System.Console.WriteLine("0 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    Adicionar(ref dicio);
                    break;

                    case 2:
                    Remover(ref dicio);
                    break;

                    case 3:
                    Buscar(dicio);
                    break;

                    case 4:
                    Mostrar(dicio);
                    break;

                    case 0:
                    sair = true;
                    break;
                    
                }
            } while (!sair);
        }

        public static void Adicionar (ref Dictionary<string, DateTime> dicio)
        {
            System.Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite a data de nascimento: ");
            DateTime niv = DateTime.Parse(Console.ReadLine());
            dicio.Add(nome, niv);
            System.Console.WriteLine("Pessoa adicionada");
            Console.ReadLine();
            
        }
        public static void Remover (ref Dictionary<string, DateTime> dicio)
        {
            System.Console.Write("Digite o nome a ser removido: ");
            string nome = Console.ReadLine();
            if (dicio.ContainsKey(nome))
            {
                dicio.Remove(nome);
                System.Console.WriteLine("Nome removido");
            }else
            {
                System.Console.WriteLine("Nome não encontrado");
            }
            Console.ReadLine();
            
        }
        public static void Buscar (Dictionary<string, DateTime> dicio)
        {
            System.Console.Write("Digite o nome para busca: ");
            string nome = Console.ReadLine();
            if (dicio.ContainsKey(nome))
            {
                System.Console.Write($"Nome: {nome} {dicio[nome]}");
            }else
            {
                System.Console.WriteLine("Nome não encontrado");
            }
            Console.ReadLine();
            
        }
        public static void Mostrar (Dictionary<string, DateTime> dicio)
        {
            foreach (var item in dicio)
            {
                System.Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }
    }
}
