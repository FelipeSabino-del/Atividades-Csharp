using System;

namespace _19_VetorUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Escolha um número inteiro de limite do seu vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];

            System.Console.WriteLine($"Digite {n} números: ");

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                vet[i] = x;
            }

            Console.Clear();
            
            foreach (int item in vet)
            {
                System.Console.WriteLine($"N° {item}");
            }


        }
    }
}
