using System;

namespace NumeroInfinito_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();           
            Console.Write("Digite um número qualquer e sua resposta será sempre 3: ");
            double n = double.Parse(Console.ReadLine());

            double result = ((2*n + 6)/ 2) - n;
            System.Console.WriteLine(result);
        }
    }
}
