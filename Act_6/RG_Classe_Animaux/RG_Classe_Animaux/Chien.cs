using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Animaux
{
    internal class Chien : Animal
    {
        public Chien(string nom, bool animalConcours, int puce, int taille, DateTime naissance) : base(nom, animalConcours, puce, taille, naissance)
        {

            _nom = nom;
            _animalConcours = animalConcours;
            _puce = puce;
            _taille = taille;
            _naissance = naissance;

        }

        public string Aboyer()
        {
            string info = "Le " + _nom + "aboie";
            return info;
        }
    }
}
