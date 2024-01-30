using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Employe
{
    internal class Cadre : Employe
    {
        private int _indice;
        public Cadre(int indice, string matricule, string nom, string prenom, double salaire, DateTime naissance) : base(matricule, nom, prenom, salaire, naissance)
        {
            _indice = indice;
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
