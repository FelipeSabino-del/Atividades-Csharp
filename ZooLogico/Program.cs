using System;
using System.Linq;
using ZooLogico.Interfaces;
using ZooLogico.Models.Animais;
using System.Collections.Generic;

namespace ZooLogico
{
    /**
     * ----------------------------------------------------------------------------------------------------
     * * _Aplicação: Zoo Lógico
     * * _Branch: master
     * * TEMA: INTERFACE E POLIMORFISMO
     * ----------------------------------------------------------------------------------------------------
     *   Objetivo: Exercitar o polimorfismo usando interfaces.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Variável de controle do Loop Principal
            bool encerrouPrograma = false;
            Animal [] Pasto = new Animal[3];
            Animal [] Gaiola = new Animal[3];
            Animal [] CasaArvore = new Animal[3];
            Animal [] Caverna = new Animal[3];
            Animal [] LagoGelo = new Animal[3];
            Animal [] Lago = new Animal[3];
            Animal [] Aquario = new Animal[3];
            

                        #region Loop Principal
            do
            {
                #region Menu Principal
                var codigo = 0;
                Console.Clear();
                System.Console.WriteLine("===============================");
                System.Console.WriteLine("|  Bem- vindo ao Zoo Lógico!  |");
                System.Console.WriteLine("===============================");
                // Gerar os itens do menu de forma automática
                foreach (var item in Arca.Animais.Values)
                {
                    System.Console.WriteLine($"{++codigo}. {item.GetType().Name}");
                }
                #endregion
                System.Console.Write($"Digite o código do animal: ");
                
                // Testando se o usuário digitou um código correto ou não
                try
                {
                    int opcaoUsuario = int.Parse(Console.ReadLine());
                    var animal = Arca.Animais[opcaoUsuario];
                    ClassificarAnimal(animal, Pasto, Gaiola, CasaArvore, Caverna,LagoGelo, Lago, Aquario, opcaoUsuario);
                    
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Por favor, digite um código válido");
                    Console.ReadLine();                    
                }

                
            } while (!encerrouPrograma);
            #endregion
        }
        public static void ClassificarAnimal(Animal animal, Animal [] Pasto, Animal [] Gaiola, Animal [] CasaArvore, Animal [] Caverna, Animal [] LagoGelo, Animal [] Lago, Animal [] Aquario, int opcaoUsuario)
        {
            // Esse @ é para que possamos usar o nome interface para a variável, que é uma palavra reservada do C#!
            var classe = animal.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();

            if ((typeof(IAquatico)).Equals(@interface))
            {
                int index = 0;
                opcaoUsuario -= -1;
                foreach (var item in Lago)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina:::");
                        LagoGelo[index] = animal;
                        var remover = Arca.Animais.Remove(Arca.Animais.ElementAt(opcaoUsuario).Key);
                        break;
                    }
                    ++index;
                }
            }
            else if ((typeof(IArboricula)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in CasaArvore)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine($":::{classe.Name} pode ir para a Casa na Árvore:::");
                        CasaArvore[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);
                        break;
                    }
                    ++index;
                }
            }
            else if ((typeof(IBranquiado)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in Aquario)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine($":::{classe.Name} pode ir para o Aquário:::");
                        Aquario[index] = animal;
                        var remover = Arca.Animais.Remove(Arca.Animais.ElementAt(opcaoUsuario).Key);
                        
                        break;
                    }
                    ++index;
                }
            }
            else if ((typeof(IQuionofilo)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in LagoGelo)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina Gelada:::");
                        LagoGelo[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);
                        break;
                    }
                    ++index;
                }
            }
            else if ((typeof(ITerrestre)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in Caverna)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine($":::{classe.Name} pode ir para os Pastos ou Caverna de Pedra:::");
                        Pasto[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);
                        break;
                    }
                    ++index;
                }
            }
            else if ((typeof(IVoador)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in Gaiola)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine($":::{classe.Name} pode ir para a Gaiola:::");
                        Gaiola[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);
                        break;
                    }
                    ++index;
                }
            }

            Console.ReadLine();

        }


    }
}
