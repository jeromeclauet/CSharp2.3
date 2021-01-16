using System;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un identifiant !");
            string login = Console.ReadLine();
            Console.WriteLine("Veuillez entrer un mot de passe !");
            string password = Console.ReadLine();

            switch(login)
            {
                case "jéjé":
                    switch(password)
                    {
                        case "marabout":
                            Console.WriteLine("Bienvenue à la Manu");
                            break;
                        default:
                            Console.WriteLine("Identifiant ou mot de passe incorrect");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Identifiant ou mot de passe incorrect");
                    break;
            }
        }
    }
}
