using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int val1, val2;
            int solution;
            int choix;

            while (true)
            {
                // 1. Affichage du menu
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix : ");

                if (!int.TryParse(Console.ReadLine(), out choix))
                {
                    Console.WriteLine("Erreur : Veuillez entrer un nombre valide (les lettres sont interdites).\n");
                    continue;
                }

                // 3. Gestion de la sortie (Quitter)
                if (choix == 0)
                {
                    Console.WriteLine("Au revoir !");
                    break; // Quitte la boucle et arrête le programme proprement
                }

                // 4. Gestion des choix invalides (hors 1 et 2)
                if (choix < 1 || choix > 2)
                {
                    Console.WriteLine("Erreur de saisie ! Réessayez.\n");
                    continue;
                }

                // 5. Traitement de l'Addition (choix == 1)
                if (choix == 1)
                {
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);

                    Console.Write(val1 + " + " + val2 + " = ");

                    // Sécurisation aussi de la réponse au calcul (évite le crash si on tape des lettres)
                    if (int.TryParse(Console.ReadLine(), out int reponse))
                    {
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !\n");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution + "\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ce n'était pas un nombre valide pour la réponse !\n");
                    }
                }
                // 6. Traitement de la Multiplication (choix == 2)
                else if (choix == 2)
                {
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);

                    Console.Write(val1 + " x " + val2 + " = ");

                    // Sécurisation de la réponse de la multiplication
                    if (int.TryParse(Console.ReadLine(), out int reponse))
                    {
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !\n");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution + "\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ce n'était pas un nombre valide pour la réponse !\n");
                    }
                }
            }
        }
    }
}