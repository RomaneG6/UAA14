﻿using System;
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
        private bool _vaccin;
        private bool _puce;
        private string _genre;
        private bool _sterile;
        private bool _dresse;

        public Chien(string nom, string race, uint age, bool vaccin, bool puce, string genre, bool sterile)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _vaccin = vaccin;
            _puce = puce;
            _genre = genre;
            _sterile = sterile;
        }

        public uint age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string AfficheCarac()
        {
            string chaine = "Nom : " + _nom + "Race : " + _race + "Age : " + _age + "Vaccin : " + _vaccin + "Puce : " + _puce + "Genre : " + _genre + "Sterile : " + _sterile;
            return chaine;
        }

    }
}
