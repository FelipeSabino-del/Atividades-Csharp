using System;

namespace _3_Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do seu combustível");
            System.Console.WriteLine();
            System.Console.Write ("Digite o tempo gasto na viagem em horas: ");
            double tempo = double.Parse (Console.ReadLine ());
            System.Console.Write ("Digite a velocidade média de sua viagem em Km: ");
            double velocidade = double.Parse (Console.ReadLine ());
            System.Console.WriteLine();

            double dist = tempo * velocidade;
            System.Console.WriteLine($"Distância percorrida: {dist}Km");

            double gas = dist / 12;
            System.Console.WriteLine($"Gasolina gasta na viagem: {gas}L");


        }
    }
}
