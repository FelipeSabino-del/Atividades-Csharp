using System;

namespace _12_OrdemNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Cálculo do seu combustível");
            // System.Console.WriteLine();
            // System.Console.Write ("Digite o tempo gasto na viagem em horas: ");
            // double tempo = double.Parse (Console.ReadLine ());
            // System.Console.Write ("Digite a velocidade média de sua viagem em Km: ");
            // double velocidade = double.Parse (Console.ReadLine ());
            // System.Console.WriteLine();

        int a = 5;
        int b = 6;
        int c = 5;

        int ab = a.CompareTo(b);
        int ba = b.CompareTo(a);
        int ca = c.CompareTo(a);

        Console.WriteLine(ab);
        Console.WriteLine(ba);
        Console.WriteLine(ca);
        }
    }
}
