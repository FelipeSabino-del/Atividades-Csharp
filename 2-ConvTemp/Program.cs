using System;

namespace _2_ConvTemp {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Conversão de temperatura");
            System.Console.WriteLine ();
            Console.WriteLine ("Digite a temperatura que deseja converter para Fahrenheit");
            double temp = double.Parse (Console.ReadLine ());
            Console.Clear ();
            System.Console.Write ("Sua temperatura de: ");
            System.Console.WriteLine ($"{temp}°C");
            System.Console.WriteLine ();

            double F = (temp * 9) / 5 + 32;
            System.Console.WriteLine ($"Convertida é: {F}°F");
        }
    }
}