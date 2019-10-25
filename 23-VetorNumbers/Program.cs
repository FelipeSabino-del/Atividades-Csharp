using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _23_VetorNumbers {
    class Program {
        static void Main (string[] args) {
            int[] V = new int[10];
            Random random = new Random ();

            List<int> lista = new List<int> ();

            for (int i = 0; i < 10; i++) 
            {
                    V[i] = random.Next (0, 10);
            }
            foreach (int item in V) 
            {
                lista.Add (item);
            }
            System.Console.Write ("Itens: ");

            foreach (int item in lista) 
            {
                System.Console.Write ($"{item} ");
            }
            int total = 0;
            for (int i = 0; i < 10; i++) 
            {
                    total += V[i];
                
            }
            System.Console.WriteLine ($"\nSoma total: {total}");
        }
    }
}