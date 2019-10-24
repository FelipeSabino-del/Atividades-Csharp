using System;

namespace _9_Gravidade {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();
            System.Console.WriteLine ("=====================");
            System.Console.WriteLine ("Seu peso nos planetas");
            System.Console.WriteLine ("=====================");
            Console.ReadLine ();
            bool sair = false;

            do {

                System.Console.WriteLine ("1 - Mercúrio");
                System.Console.WriteLine ("2 - Vênus");
                System.Console.WriteLine ("3 - Marte");
                System.Console.WriteLine ("4 - Júpiter");
                System.Console.WriteLine ("5 - Saturno");
                System.Console.WriteLine ("6 - Urano");
                System.Console.WriteLine ("0 - Sair");
                int opcao = int.Parse (Console.ReadLine ());

                double Pplaneta;
                double peso;
                switch (opcao) {
                    case 1:
                        System.Console.Write ("Digite seu peso: ");
                        peso = double.Parse (Console.ReadLine ());
                        Pplaneta = peso  * 0.37;
                        System.Console.WriteLine ($"Seu peso nesse planeta é: {Pplaneta}Kg");
                        Console.ReadLine();
                        break;

                    case 2:
                        System.Console.Write ("Digite seu peso: ");
                        peso = double.Parse (Console.ReadLine ());
                        Pplaneta = peso * 0.88;
                        System.Console.WriteLine ($"Seu peso nesse planeta é: {Pplaneta}Kg");
                        Console.ReadLine();
                        break;

                    case 3:
                        System.Console.Write ("Digite seu peso: ");
                        peso = double.Parse (Console.ReadLine ());
                        Pplaneta = peso* 0.38;
                        System.Console.WriteLine ($"Seu peso nesse planeta é: {Pplaneta}Kg");
                        Console.ReadLine();
                        break;

                    case 4:
                        System.Console.Write ("Digite seu peso: ");
                        peso = double.Parse (Console.ReadLine ());
                        Pplaneta = peso * 2.64;
                        System.Console.WriteLine ($"Seu peso nesse planeta é: {Pplaneta}Kg");
                        Console.ReadLine();
                        break;

                    case 5:
                        System.Console.Write ("Digite seu peso: ");
                        peso = double.Parse (Console.ReadLine ());
                        Pplaneta = peso * 1.15;
                        System.Console.WriteLine ($"Seu peso nesse planeta é: {Pplaneta}Kg");
                        Console.ReadLine();
                        break;

                    case 6:
                        System.Console.Write ("Digite seu peso: ");
                        peso = double.Parse (Console.ReadLine ());
                        Pplaneta = peso * 1.17;
                        System.Console.WriteLine ($"Seu peso nesse planeta é: {Pplaneta}Kg");
                        Console.ReadLine();
                        break;

                    case 0:
                        sair = true;
                        break;

                }
            } while (!sair);
        }
    }
}