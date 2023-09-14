using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables : c1, c2, c3, a, b, c et ok

            string rep;
            string infos = "";
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            // instanciation de la structure
            MethodesDuProjet outils = new MethodesDuProjet();

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                // c1 = premier coté
                // c2 = deuxième coté
                // c3 = troisième coté

                // ordonner les côtés => APPEL (ORDONNECOTES)triangle
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);
                // c1 = le coté le plus grand et les deux autres cotés sont c2 et c3
                // série de test (voir consignes)
                if (outils.Triangle(ref c1, ref c2, ref c3) == true)// on a un triangle
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    ok = true;
                    outils.Affiche(ref ok, "triangle", out infos);
                    Console.WriteLine(infos);
                    

                    // vérification équilatéral
                    if (outils.Equi(c1, c2, c3) == true)// on a un triangle équilatéral
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        ok = true;
                        outils.Affiche(ref ok, "equilateral", out infos);
                        Console.WriteLine(infos);
                        outils.TriangleRectangle(c1, c2, c3);
                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (outils.TriangleRectangle(c1, c2, c3) == true)// on a un triangle rectangle
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            ok = true;
                            outils.Affiche(ref ok, "rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            ok = false;
                            outils.Affiche(ref ok, "rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        //...
                        //...
                        //... A vous de voir en combien de lignes...
                        outils.Isocele(ref c1, ref c2, ref c3, out ok);
                        if (ok == true)
                        {
                            outils.Affiche(ref ok, "isocele", out infos);
                            Console.WriteLine(infos);
                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                    ok = false;
                    outils.Affiche(ref ok, "triangle", out infos);
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
