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
                    Console.Clear();
                    System.Console.WriteLine("1 - Adicionar contato");
                    System.Console.WriteLine("2 - Atualizar contato");
                    System.Console.WriteLine("3 - Remover contato");
                    int opcao2 = int.Parse(Console.ReadLine());
                        switch (opcao2)
                        {
                            case 1:
                            Adicionar(ref lista);
                            break;
                            case 2:
                            Atualizar(ref lista);
                            break;
                            case 3:
                            Remover(ref lista);
                            break;
                        }
                    break;

                    case 2:
                    BuscarNome(lista);
                    break;

                    case 3:
                    BuscarTelefone(lista);
                    break;

                    case 4:
                    Mostrar(lista);
                    break;

                    case 0:
                    sair = true;
                    break;

                    default:
                    System.Console.WriteLine("Comando inválido");
                    break;
                    
                }
            } while (!sair);
        }

        public static void Adicionar (ref List<Registro> lista)
        {
            Console.Clear();
            System.Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite o número do telefone: ");
            string tel = Console.ReadLine();
            System.Console.Write("Digite a data de nascimento: ");
            string niv = Console.ReadLine();
            Registro cont1 = new Registro(nome,tel ,niv );
            lista.Add(cont1);
            Console.Clear();
            System.Console.WriteLine("Pessoa adicionada");
            System.Console.WriteLine($"Nome: {cont1._Nome}");
            System.Console.WriteLine($"Telefone: {cont1._Telefone}");
            System.Console.WriteLine($"Dt nascimento: {cont1._Aniversario}");
            Console.ReadLine();
            
        }
        public static void Atualizar (ref List<Registro> lista)
        {
            Console.Clear();
            System.Console.WriteLine("Digite o nome a ser mudado");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Digite o número do contato a ser mudado");
            string tel = Console.ReadLine();
            
            bool foi = false;
            foreach (var item in lista)
            {
                if (nome == item._Nome && tel == item._Telefone)
                {
                    System.Console.Write("Digite o novo nome: ");
                    string nomeNew = Console.ReadLine();
                    if (nomeNew == "")
                    {
                        nomeNew = nome;
                    }
                    System.Console.Write("Digite o novo número do telefone: ");
                    string telNew = Console.ReadLine();
                    if (telNew == "")
                    {
                        telNew = tel;
                    }
                    System.Console.Write("Digite a nova data de nascimento: ");
                    string niv = Console.ReadLine();
                    if (niv == "")
                    {
                        
                    }else
                    {
                        item._Aniversario = niv;                       
                    }

                    item._Nome = nomeNew;
                    item._Telefone = telNew;
                    foi = true;
                    break;
                }               
            }if (foi == false)
            {
                System.Console.WriteLine("Erro, contato não encontrado");
            }
            Console.ReadLine();
            
        }
        public static void Remover (ref List<Registro> lista)
        {
            Console.Clear();
            System.Console.Write("Digite o nome a ser removido: ");
            string nome = Console.ReadLine();
            bool antbug = false;
            foreach (var item in lista)
            {
                
                if (nome == item._Nome)
                {
                    lista.Remove(item);
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
        public static void BuscarNome (List<Registro> lista)
        {
            Console.Clear();
            System.Console.Write("Digite o nome para busca: ");
            string nome = Console.ReadLine();
            bool foi = false;
            foreach (var item in lista)
            {
                
                if (nome == item._Nome)
                {
                    System.Console.WriteLine($"Nome encontrado: {item._Nome}");
                    System.Console.WriteLine($"Número do contato: {item._Telefone}");
                    foi = true;
                    break;
                }
            }if (foi == false)
            {
                System.Console.WriteLine("Erro, contato não encontrado");
            }
            
            Console.ReadLine();
            
        }
        public static void BuscarTelefone (List<Registro> lista)
        {
            Console.Clear();
            System.Console.Write("Digite o número para busca: ");
            string tel = Console.ReadLine();
            bool foi = false;
            foreach (var item in lista)
            {
                
                if (tel == item._Telefone)
                {
                    System.Console.WriteLine($"Número encontrado: {item._Telefone}");
                    System.Console.WriteLine($"Pertence ao: {item._Nome}");
                    foi = true;
                    break;
                }
            }if (foi == false)
            {
                System.Console.WriteLine("Erro, contato não encontrado");
            }
            
            Console.ReadLine();
            
        }
        public static void Mostrar (List<Registro> lista)
        {
            Console.Clear();
            System.Console.WriteLine();
            int x = 1;
            foreach (var item in lista)
            {
                System.Console.WriteLine($"{x} - Nome: {item._Nome} | Telefone: {item._Telefone} | Dt. nascimento: {item._Aniversario}");
                x ++;
            }
            Console.ReadLine();
            
        }
    }
}