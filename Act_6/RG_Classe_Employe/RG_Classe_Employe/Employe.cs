using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Employe
{
    TimeSpan tempsEcoule = DateTime.Today - dateEntree;
    internal class Employe
    {
        protected string _matricule;
        protected string _nom;
        protected string _prenom;
        protected double _salaire;
        protected DateTime _naissance;

        public Employe(string matricule, string nom, string prenom, double salaire, DateTime naissance)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _salaire = salaire;
            _naissance = naissance;
        }
        public virtual string Afficher()
        {
            string info = "Matricule : " + _matricule + "\nNom : " + _nom + "\nPrenom : " + _prenom + "\nSalaire : " + _salaire + "\nNaissance : " + _naissance;
            return info;
        }
    }
}
