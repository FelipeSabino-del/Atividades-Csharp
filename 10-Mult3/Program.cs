using System;

namespace _10_Mult3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao teste de Multiplo");
            System.Console.Write ("Digite o número que deseja testar: ");
            int n = int.Parse (Console.ReadLine ());
            System.Console.WriteLine();

            if (n %3 == 0)
            {
                System.Console.WriteLine("Seu número é múltiplo de 3");
            }else
            {
                System.Console.WriteLine("Seu número não é múltiplo de 3");
            }
        }
    }
}
