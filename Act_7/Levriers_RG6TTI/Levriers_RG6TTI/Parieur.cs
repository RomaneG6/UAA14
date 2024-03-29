using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levriers_RG6TTI
{
    internal class Parieur
    {
        private uint _numChien;
        private double _longueurPiste;
        private int _positionCourse;
        private Image _image;
        private bool _gagne;

        public uint NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }
        public double LongueurPiste
        {
            get { return _longueurPiste; }
            set { _longueurPiste = value; }
        }
        public int PositionCourse
        {
            get { return _positionCourse; }
            set { _positionCourse = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public bool Gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }
    }
}
