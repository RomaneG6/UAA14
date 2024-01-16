using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Formes
{
    internal class Rectangle : Forme
    {
        private double _longueur;
        private double _largeur;

        public double Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }
        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public Rectangle(double longueur, double largeur, string couleur) : base(couleur)
        {
            _couleur = couleur;
            _longueur = longueur;
            _largeur = largeur;
        }
        public override string Afficher()
        {
            string info = "la couleur : " + _couleur + "\nLa longueur : " + _longueur + "\n La largeur : " + _largeur;
            return info;
        }
        public double CalculeSurface()
        {
            double calculS = _longueur * _largeur;
            return calculS;
        }
        public double CalculePerimetre()
        {
            double calculP = _longueur + _largeur + _longueur + _largeur;
            return calculP;
        }
    }
}
