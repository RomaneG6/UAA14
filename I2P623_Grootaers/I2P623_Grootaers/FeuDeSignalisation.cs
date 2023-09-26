using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace I2P623_Grootaers
{
    class FeuDeSignalisation
    {
        private string _nom;
        private int _couleur;
        public FeuDeSignalisation(string nom, int couleur)
        {
            _nom = nom;
            _couleur = couleur;
        }

        public string Nom
        {
            get { return _nom; }
        }

        public int Couleur
        {
            get { return _couleur; }
        }

        public void Clignoter(bool clignotant)
        {
            if (clignotant == false)
            {
                clignotant = true;
            }
            else
            {
                clignotant = false;

            }
    
        }
        public void CouleurChangementDeCouleur(int couleur)
        {
            if (couleur == 1)
            {
                couleur = 2;
            }
            else if (couleur == 2)
            {
                couleur = 3;

            }
            else if (couleur == 3)
            {
                couleur = 1;
            }

        }
        public void AfficherClignotant(bool clignotant, string chaine)
        {
            if (clignotant == false)
            {
                 chaine = "Le " + _nom + "est éteint";

            }
            else
            {
                chaine = "Le " + _nom + "est allumé";

            }
        }
        public void AfficherCouleur(int couleur, string chaine)
        {
            if (couleur == 1)
            {
                chaine = "Le " + _nom + "est Vert";

            }
            else if (couleur == 2)
            {
                chaine = "Le " + _nom + "est Orange";

            }
            else if(couleur == 3)
            {
                chaine = "Le " + _nom + "est Rouge";
            }
        }
    }
}
