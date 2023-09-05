using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExChien
{
    class Chien
    {
        private string _nom;
        private string _race;
        private uint _age;
        public Chien(string nom, string race, uint age)
        {
            _nom = nom;
            _race = race;
            _age = age;
        }
        public string AfficheCarac()
        {
            string chaine = "- Nom : " + _nom + " - Race : " + _race + " - Age : " + _age;
            return chaine;
        }

    }
}
