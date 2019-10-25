using System;

namespace _17_120a300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("120 a 300");
            System.Console.Write ("ENTER para começar");
            Console.ReadLine();
            System.Console.WriteLine();

            for (int i = 0; i <= 300; i++)
            {
                if (i >= 120 && i <= 300 )
                {
                    System.Console.WriteLine($"N° {i}");
                }
            }
        }
    }
}
