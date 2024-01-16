using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Animaux
{
    internal class Animal
    {
        protected string _nom;
        protected bool _animalConcours;
        protected int _puce;
        protected int _taille;
        protected DateTime _naissance;

        public Animal(string nom, bool animalConcours, int puce, int taille, DateTime naissance)
        {
            _nom = nom;
            _animalConcours = animalConcours;
            _puce = puce;
            _taille = taille;
            _naissance = naissance;

        }
        public virtual string Afficher()
        {
            string info = "Nom : " + _nom + "\nanimalConcours : " + _animalConcours + "\npuce : " + _puce + "\ntaille : " + _taille + "\nnaissance : " + _naissance;
            return info;
        }
        public string Manger()
        {
            string info = "Le " + _nom + "mange";
            return info;
        }
        public string Dormir()
        {
            string info = "Le " + _nom + "dort";
            return info;
        }
    }
}
