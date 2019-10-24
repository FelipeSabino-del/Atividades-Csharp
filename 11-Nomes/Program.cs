using System;

namespace _11_Nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o segundo nome: ");
            string nome2 = Console.ReadLine();

            int compare = string.Compare(nome, nome2);

            if (compare < 0)
            {
                System.Console.WriteLine($"{nome}\n{nome2}");
            }else
            {
                System.Console.WriteLine($"{nome2}\n{nome}");
            }
            
        }
    }
}
