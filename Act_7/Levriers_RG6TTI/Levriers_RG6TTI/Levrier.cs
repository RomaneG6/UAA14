using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Levriers_RG6TTI
{
    internal class Levrier
    {
        private uint _numChien;
        private double _longueurPiste;
        private int _positionCourse;
        private Image _image;
        private bool _gagne;

        public uint numChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }
        public double longueurPiste
        {
            get { return _longueurPiste; }
            set { _longueurPiste = value; }
        }
        public int positionCourse
        {
            get { return _positionCourse; }
            set { _positionCourse = value; }
        }
        public Image image
        {
            get { return _image; }
            set { _image = value; }
        }
        public bool gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }

        public Levrier(uint _numChien, double _longueurPiste, int _positionCourse, Image _image, bool _gagne) 
        {
            _numChien = numChien;
            _longueurPiste = longueurPiste;
            _positionCourse = positionCourse;
            _image = image;
            _gagne = gagne;
        }
    }
}
