using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

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

            Random random = new Random ();
            Random random2 = new Random ();

            
            for (int i = 0; i < x; i++) 
            {
                    V[i] = random.Next (0, 100);
                    V2[i] = random2.Next (0, 100);
                    
            }
            List<int> lista = new List<int>();
            lista.AddRange(V);
            lista.AddRange(V2);
            int[] total = lista.ToArray();
            



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
            
            
            foreach (var item in total)
            {
                System.Console.Write($"{item} ");
            }
    }
    }
}