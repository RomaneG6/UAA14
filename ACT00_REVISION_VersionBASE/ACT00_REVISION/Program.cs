﻿using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables : c1, c2, c3, a, b, c et ok

            string rep;
            string methode = "";
            string infos = "";
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            bool ok = false;
            // instanciation de la structure
            MethodesDuProjet outils = new MethodesDuProjet();
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                // c1 = premier coté
                // c2 = deuxième coté
                // c3 = troisième coté

                // ordonner les côtés => APPEL ORDONNECOTES
                lireDouble(a);
                lireDouble(b);
                lireDouble(c);
                outils.Triangle(ref a, ref b, ref c, ref ok);
                // c1 = le coté le plus grand et les deux autres cotés sont c2 et c3
                // série de test (voir consignes)
                if (ok == true)// on a un triangle
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                    outils.Affiche(ok, methode, out infos);
                    Console.WriteLine(infos);
                    outils.Equi(a, b, c);

                    // vérification équilatéral
                    if (ok == true)// on a un triangle équilatéral...
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        // ...
                        // ...
                        outils.Affiche(ok, methode, out infos);
                        Console.WriteLine(infos);
                        outils.TriangleRectangle(a, b, c);
                    }
                    else
                    {
                        outils.TriangleRectangle(a, b, c);
                        // vérification triangle rectangle
                        if (ok == true)// on a un triangle rectangle
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            // ...
                            // ...
                            outils.Affiche(ok, methode, out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            // ...
                            // ...
                            outils.Affiche(ok, methode, out infos);
                            Console.WriteLine(infos);
                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        //...
                        //...
                        //... A vous de voir en combien de lignes...
                        outils.Isocele(ref a, ref b, ref c);
                        if (ok == true)
                        {
                            outils.Affiche(ok, methode, out infos);
                            Console.WriteLine(infos);
                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                    outils.Affiche(ok, methode, out infos);
                    Console.WriteLine(infos);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(double numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
