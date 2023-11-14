using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT2_6TTIRG
{
    internal class Cercle
    {
        private int _rayon;
        public Cercle(int rayon)
        {
            _rayon = rayon;
        }

        public int Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }
    }
}