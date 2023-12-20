using System.Threading.Channels;

namespace CeUAA14Partie2_dec23_Grootaers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool recom = true;//c'est une boucle que l'utilisateur peut quitté quand il veut en appuyant su q
            string choix;//c'est choix qui fait en sorte que le joueur ne peut pas appuyer sur toute les touches du clavier mais juste sur celles désignée
            

            PaintBallGun PaintBallGun1 = new PaintBallGun(30, 0, "vide");
            Console.WriteLine("Bienvenue dans ce jeu de tir!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            while (recom == true)
            {
                Console.WriteLine("\n=> Appuyez sur :\n" +
                                "   Espace pour tirer,\n" +
                                "   r pour recharger l'arme,\n" +
                                "   + pour reprendre des munitions,\n" +
                                "   q pour quitter");
                Console.WriteLine(PaintBallGun1.AfficherInfo());
                choix = Console.ReadLine();
                if (choix == " ")
                {
                    Console.WriteLine(PaintBallGun1.Tirer());
                }
                else if (choix == "r")
                {
                    Console.WriteLine(PaintBallGun1.Recharger());
                }
                else if (choix == "+")
                {
                    Console.WriteLine(PaintBallGun1.ReprendreB());
                }
                else if (choix == "q")
                {
                    recom = false;
                }
                else
                {
                    Console.WriteLine("Veuillez réessayer !");
                    recom = true;
                }
                Console.WriteLine(PaintBallGun1.AfficherInfo());
            }
        }
    }
}