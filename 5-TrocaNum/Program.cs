using System;

namespace _5_TrocaNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número malucos");
            System.Console.Write ("Digite um número: ");
            double A = double.Parse (Console.ReadLine ());
            System.Console.Write ("Digite outro número: ");
            double B = double.Parse (Console.ReadLine ());
            System.Console.WriteLine();

            System.Console.WriteLine($"Primeiro valor: {A}");
            System.Console.WriteLine($"Segundo valor: {B}");
            System.Console.WriteLine();

            A += B;
            B = A - B;
            A -= B;
            

            System.Console.WriteLine($"Novo primeiro valor: {A}");
            System.Console.WriteLine($"Novo segundo valor: {B}");
            System.Console.WriteLine();
        }
    }
}
