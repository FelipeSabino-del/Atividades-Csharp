using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _25_VetoresUser
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o tamanho desejado: ");
            int x = int.Parse(Console.ReadLine());
            int[] V = new int[x];
            int[] V2 = new int[x];
            int[] total = new int[x];
            Random random = new Random ();
            Random random2 = new Random ();

            
            for (int i = 0; i < x; i++) 
            {
                    V[i] = random.Next (0, 100);
                    V2[i] = random2.Next (0, 100);
                    total[i] = Convert.ToInt32(V[i].ToString() + V2[i].ToString());
            }



            foreach (var go in V)
            {
                System.Console.Write($"{go} ");
            }
            System.Console.WriteLine();
            foreach (var go1 in V2)
            {
                System.Console.Write($"{go1} ");
            }
            System.Console.WriteLine();
            Console.ReadLine();
            
            for (int l = 0; l < x; l++)
            {
            }
            
            foreach (var item in total)
            {
            System.Console.Write($"{item} ");
        }
    }
    }
}