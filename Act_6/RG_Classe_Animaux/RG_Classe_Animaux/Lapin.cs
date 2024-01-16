using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG_Classe_Animaux
{
    internal class Lapin : Animal
    {
        private int _tailleOreilles;
        public Lapin(string nom, bool animalConcours, int puce, int taille, DateTime naissance, int tailleOreilles) : base(nom, animalConcours, puce, taille, naissance)
        {

            _nom = nom;
            _animalConcours = animalConcours;
            _puce = puce;
            _taille = taille;
            _naissance = naissance;
            _tailleOreilles = tailleOreilles;

        }
        public override string Afficher()
        {
            string info = "Nom : " + _nom + "\nanimalConcours : " + _animalConcours + "\npuce : " + _puce + "\ntaille : " + _taille + "\nnaissance : " + _naissance + "\nTaille des oreilles :" + _tailleOreilles;
            return info;
        }
        public string Bondir()
        {
            string info = "Il bondit";
            return info;
        }
     
    }
}
