using System;

namespace _13_NumTriang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lados de um triângulo");

            System.Console.Write ("Digite um lado: ");
            double l1 = double.Parse (Console.ReadLine ());

            System.Console.Write ("Digite outro lado: ");
            double l2 = double.Parse (Console.ReadLine ());

            System.Console.Write ("Digite outro lado: ");
            double l3 = double.Parse (Console.ReadLine ());
            System.Console.WriteLine();

            if (l1 != 0 && l2 != 0 && l3 != 0)
            {
                if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
                {
                    System.Console.WriteLine("Seu triângulo é válido");
                }else{
                System.Console.WriteLine("Lados inválidos");
            }
            }else
            {
                System.Console.WriteLine("Lado 0 é inválido");
            }
        }
    }
}
