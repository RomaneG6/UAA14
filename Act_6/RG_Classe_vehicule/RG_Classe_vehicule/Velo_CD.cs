using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_vehicule
{
    internal class Velo_CD : Vehicule_CB
    {
        private string _type;
        private bool _electrique;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool Electrique
        {
            get { return _electrique; }
            set { _electrique = value; }
        }
        public Velo_CD(string type, bool electrique, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _type = type;
            _electrique = electrique;
        }
        public override string Afficher()
        {
            string info = "modèle : " + _modele + "\nla marque : " + _marque + "\nla couleur : " + _couleur + "\nle prix : " + _prix + "\nle type : " + _type + "\nEst ce que le vélo est électrique : " + _electrique;
            return info;
        }
    }
}
