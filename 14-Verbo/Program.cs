using System;

namespace _14_Verbo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu verbo: ");
            string verbo = Console.ReadLine();
            verbo = verbo.ToLower();
            
            bool conj1 = verbo.EndsWith("ar");
            bool conj2 = verbo.EndsWith("er");
            bool conj3 = verbo.EndsWith("ir");

            if (conj1)
            {
                System.Console.WriteLine("1ª Conjugação");
            }else if (conj2)
            {
                System.Console.WriteLine("2ª Conjugação");
            }else if (conj3)
            {
                System.Console.WriteLine("3ª Conjugação");
            }
        }
    }
}
