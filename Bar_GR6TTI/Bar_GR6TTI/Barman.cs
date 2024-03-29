using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_GR6TTI
{
    internal class Barman
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public Barman(string Nom)
        {
            _nom = Nom;
        }

    }
}
