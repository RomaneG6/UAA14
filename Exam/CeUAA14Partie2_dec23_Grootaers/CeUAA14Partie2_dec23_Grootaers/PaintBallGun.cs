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
        private int _nbrBallesJ;//nbrBallesJ = nombre de balles dont dispose le joueur
        private int _nbrBallesChar;//nbrBallesChar = nombre de balles dont dispose le chargeur
        private string _armeVide;//armeVide = pour savoir si l'arme est vide ou chargée

        public PaintBallGun(int nbrBallesJ, int nbrBallesChar, string armeVide)
        {
            _nbrBallesJ = nbrBallesJ;
            _nbrBallesChar = nbrBallesChar;
            _armeVide = armeVide;
        }
        public int nbrBallesJ//sert à accéder à la donnée et à la modifier car elle est privée
        {
            get { return _nbrBallesJ; }
            set { _nbrBallesJ = value; }
        }
        public int nbrBallesChar//sert à accéder à la donnée et à la modifier car elle est privée
        {
            get { return _nbrBallesChar; }
            set { _nbrBallesChar = value; }
        }
        public string armeVide//sert à accéder à la donnée et à la modifier car elle est privée
        {
            get { return _armeVide; }
            set { _armeVide = value; }
        }
        public string AfficherInfo()// affiche les info du gun du joueur
        {
            string chaine = "\n -> Vous disposez de " + _nbrBallesJ + " balles dans votre poche,\n" +
                "votre chargeur contient " + _nbrBallesChar + " balles,\n" +
                "votre arme est " + _armeVide;

            return chaine;
        }
        public string Tirer()//indique que le joueur tire si l'arme n'est pas vide mais si elle est vide, indique qu'il ne peut pas tiré
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
        public string Recharger()//indique que le joueur recharge son arme si elle poosède moins de 16 balles mais aussi le nombre de balles qu'il met dans son arme
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
        public string ReprendreB()//indique que le joueur reprend des munition mais aussi le nombre de balles qui prends quand il le souhaite
        {
            _nbrBallesJ = _nbrBallesJ + 30;
            string chaine = " - Vous venez de reprendre des munitions";

            return chaine;
        }
    }
}
