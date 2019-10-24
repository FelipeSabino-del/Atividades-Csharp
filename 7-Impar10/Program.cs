using System;

namespace _7_Impar10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Ímpares de 0 a 10");
            System.Console.Write ("ENTER para começar");
            Console.ReadLine();
            System.Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                if (i %2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
