using System;

namespace _1_Retangulo {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Cálculos do retângulo");

            System.Console.Write ("Digite o valor da base: ");
            double b = double.Parse (Console.ReadLine ());
            System.Console.Write ("Digite o valor da altura: ");
            double h = double.Parse (Console.ReadLine ());

            double Perimetro = 2 * b + 2 * h;
            System.Console.WriteLine ($"O perímetro é: {Perimetro}");

            double Area = b*h;
            System.Console.WriteLine ($"O área é: {Area}");

            double Diagonal = (b * b) + (h * h);
            Diagonal = Math.Sqrt(Diagonal);
            System.Console.WriteLine ($"O diagonal é: {Diagonal}");

        }
    }
}