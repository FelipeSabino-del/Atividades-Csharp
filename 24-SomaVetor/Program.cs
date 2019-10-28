using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _24_SomaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] V = new int[10];
            int[] V2 = new int[10];
            int[] total = new int[10];
            Random random = new Random ();
            Random random2 = new Random ();

            
            for (int i = 0; i < 10; i++) 
            {
                    V[i] = random.Next (0, 10);
            }
            for (int j = 0; j < 10; j++) 
            {
                    V2[j] = random2.Next (0, 10);
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
            
            for (int l = 0; l < 10; l++)
            {
                total[l] = V[l] + V2[l];
            }
            
            foreach (var item in total)
            {
            System.Console.Write($"{item} ");
                
            }
        }
    }
}
