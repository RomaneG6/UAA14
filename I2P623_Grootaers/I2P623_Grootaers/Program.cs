using System.Threading.Channels;

namespace I2P623_Grootaers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int couleur = 0;
            bool clignotant = false;
            string chaine = "";
            string chaineCouleur = "";
            string chaineClignotant = "";

            FeuDeSignalisation Feu000 = new FeuDeSignalisation("feu de signalisation 000", 3);
            FeuDeSignalisation Feu101 = new FeuDeSignalisation("feu de signalisation 101", 2);
            for (int i = 0; i < 5; i++)
            {
                Feu000.AfficherCouleur(couleur,chaine);
                Feu000.CouleurChangementDeCouleur(couleur);
                Console.WriteLine(chaineCouleur);
                Feu101.AfficherClignotant(clignotant, chaine);
                Console.WriteLine(chaineClignotant);
                Feu101.Clignoter(clignotant);
            }
        }
    }
}