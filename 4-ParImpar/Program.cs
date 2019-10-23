using System;

namespace _4_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao teste de Par e Ímpar");
            System.Console.Write ("Digite o número que deseja testar: ");
            int n = int.Parse (Console.ReadLine ());
            System.Console.WriteLine();

            if (n %2 == 0)
            {
                System.Console.WriteLine("Seu número é par");
            }else
            {
                System.Console.WriteLine("Seu número é ímpar");
            }
        }
    }
}
