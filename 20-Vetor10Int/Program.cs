using System;
using System.Collections.Generic;

namespace _20_Vetor10Int {
    class Program {
        static void Main (string[] args) {
            int[] numRandom = new int[10];
            Random random = new Random ();

            for (int i = 0; i < 10; i++) 
            {
                numRandom[i] = random.Next (0, 100);
            }
            List<int> listNumPar = new List<int> ();
            List<int> listNumImpar = new List<int> ();
            foreach (int item in numRandom) 
            {
                if ((item % 2) == 0) 
                {
                    listNumPar.Add (item);
                } else 
                {
                    listNumImpar.Add (item);
                }
            }
            System.Console.Write ("Numeros pares: ");
            foreach (int item in listNumPar) {
                Console.Write ($"{item} ");
            }
            System.Console.Write ("\nNumeros impares: ");
            foreach (int item in listNumImpar) {
                Console.Write ($"{item} ");
            }
        }
    }
}