using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace POO_AgendaTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            List<Registro> lista = new List <Registro>();

            do
            {
                Console.Clear();
                System.Console.WriteLine("===========================");
                System.Console.WriteLine("    Agenda de telefones    ");
                System.Console.WriteLine("===========================");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Cadastrar, atualização e remoção de contatos");
                System.Console.WriteLine("2 - Buscar nome do contato");
                System.Console.WriteLine("3 - Buscar telefone do contato");
                System.Console.WriteLine("4 - Todos os contato");
                System.Console.WriteLine("0 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    Adicionar(ref lista);
                    break;

                    case 2:
                    Remover(ref lista);
                    break;

                    case 3:
                    Buscar(lista);
                    break;

                    case 4:
                    Mostrar(lista);
                    break;

                    case 0:
                    sair = true;
                    break;
                    
                }
            } while (!sair);
        }

        public static void Adicionar (ref List<Registro> lista)
        {
            System.Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite o número do telefone: ");
            string tel = Console.ReadLine();
            System.Console.Write("Digite a data de nascimento: ");
            string niv = Console.ReadLine();
            Registro cont1 = new Registro(nome,tel ,niv );
            System.Console.WriteLine("Pessoa adicionada");
            Console.ReadLine();
            
        }
        public static void Remover (ref List<Registro> lista)
        {
            System.Console.Write("Digite o nome a ser removido: ");
            string nome = Console.ReadLine();
            bool antbug = false;
            foreach (var item in lista)
            {
                
                if (nome == item.Nome)
                {
                    lista.Remove(nome);
                    antbug = true;
                    break;
                }
            }
            if (antbug)
            {
                System.Console.WriteLine("Removido com sucesso");
            }else
            {
                System.Console.WriteLine("Nome não encontrado");
            }
            Console.ReadLine();
            
        }
        public static void Buscar (List<Registro> lista)
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
        public static void Mostrar (List<Registro> lista)
        {
            foreach (var item in dicio)
            {
                System.Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }
        }
    }
}
