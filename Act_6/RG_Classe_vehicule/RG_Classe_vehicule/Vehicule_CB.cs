using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_vehicule
{
    internal class Vehicule_CB
    {
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }
        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
        public Vehicule_CB(string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }
      
        public virtual string Afficher()
        {
            string info = "modèle : " + _modele + "\nla marque : " + _marque + "\nla couleur : " + _couleur + "\nle prix : " + _prix;
            return info;
        }
    }
}
