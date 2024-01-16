using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_vehicule
{
    internal class Voiture_CD : Vehicule_CB
    {
        private string _motorisation;
        private bool _gps;

        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }
        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }
        public Voiture_CD(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        public override string Afficher()
        {
            string info = "modèle : " + _modele + "\nla marque : " + _marque + "\nla couleur : " + _couleur + "\nle prix : " + _prix + "\nle moteur : " + _motorisation + "\na-t-il un gps? " + _gps;
            return info;
        }
    }
}
