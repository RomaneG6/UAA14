using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Formes
{
    internal class Carre : Forme
    {
        private double _cote;
        public double Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }
        public Carre(double cote, string couleur) : base(couleur)
        {
            _couleur = couleur;
            _cote = cote;
        }
        public override string Afficher()
        {
            string info = "la couleur : " + _couleur + "\nLa longueur des côtés : " + _cote;
            return info;
        }
        public double CalculeSurface()
        {
            double calculS = _cote * _cote;
            return calculS;
        }
        public double CalculePerimetre()
        {
            double calculP = _cote + _cote + _cote + _cote;
            return calculP;
        }
    }
}
