using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CeUAA14Partie2_dec23_Grootaers
{
    internal class PaintBallGun
    {
        private int _nbrBallesJ;
        private int _nbrBallesChar;
        private string _armeVide;
        public PaintBallGun(int nbrBallesJ, int nbrBallesChar, string armeVide)
        {
            _nbrBallesJ = nbrBallesJ;
            _nbrBallesChar = nbrBallesChar;
            _armeVide = armeVide;
        }
        public int nbrBallesJ
        {
            get { return _nbrBallesJ; }
            set { _nbrBallesJ = value; }
        }
        public int nbrBallesChar
        {
            get { return _nbrBallesChar; }
            set { _nbrBallesChar = value; }
        }
        public string armeVide
        {
            get { return _armeVide; }
            set { _armeVide = value; }
        }
        public string AfficherInfo()
        {
            string chaine = "\n -> Vous disposez de " + _nbrBallesJ + " balles dans votre poche,\n" +
                "votre chargeur contient " + _nbrBallesChar + " balles,\n" +
                "votre arme est " + _armeVide;

            return chaine;
        }
        public string Tirer()
        {
            string chaine = "";
            if (_nbrBallesChar == 0)
            {
                _armeVide = "vide";
                chaine = " ! Vous ne pouvez pas tiré car votre arme est vide";
            }
            else
            {
                _armeVide = "chargé";
                _nbrBallesChar = _nbrBallesChar - 1;
                chaine = " - vous venez de tiré";
            }
            return chaine;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Recharger()
        {
            string chaine = "";
            if (_nbrBallesChar < 16 )
            {
                if (_nbrBallesJ < 16)
                {
                    _nbrBallesChar = _nbrBallesChar + _nbrBallesJ;
                }
                _nbrBallesJ = _nbrBallesJ - 16;
                _nbrBallesChar = _nbrBallesChar + 16;
                _armeVide = "chargé";
                chaine = " - Vous venez de recharger votre arme";
            }
            else
            {
                chaine = " - votre arme est déjà chargé";
            }
            return chaine;
        }
        public string ReprendreB()
        {
            _nbrBallesJ = _nbrBallesJ + 30;
            string chaine = " - Vous venez de reprendre des munitions";

            return chaine;
        }
    }
}
