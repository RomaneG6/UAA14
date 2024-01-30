using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Employe
{
    internal class Ouvrier : Employe
    {
        private DateTime _dateEntree;
        public Ouvrier(DateTime dateEntree, string matricule, string nom, string prenom, double salaire, DateTime naissance) : base(matricule, nom, prenom, salaire, naissance)
        {
            _dateEntree = dateEntree;
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _salaire = salaire;
            _naissance = naissance;
        }
        public override string Afficher()
        {
            string info = "Matricule : " + _matricule + "\nNom : " + _nom + "\nPrenom : " + _prenom + "\nSalaire : " + _salaire + "\nNaissance : " + _naissance + "chiffre d'affaire : " + _chiffreDAffaire;
            return info;
        }
    }
}
