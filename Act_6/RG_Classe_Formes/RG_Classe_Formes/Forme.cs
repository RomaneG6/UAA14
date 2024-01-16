using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Formes
{
    internal class Forme
    {
        protected string _couleur;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public Forme(string couleur)
        {
            _couleur = couleur;
        }
        public virtual string Afficher()
        {
            string info = "la couleur " + _couleur;
            return info;
        }
    }
}
