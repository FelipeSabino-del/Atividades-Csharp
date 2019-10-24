using System;

namespace _8_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Triângulos");
            // System.Console.WriteLine();
            // System.Console.WriteLine("ENTER para começar");
            // Console.ReadLine();
            Console.Write ("Digite a altura desejada: ");
            int h = int.Parse (Console.ReadLine ());

            for (int i = h; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    System.Console.Write("x");
                }
                System.Console.WriteLine("");
                
            }
        }
    }
}
