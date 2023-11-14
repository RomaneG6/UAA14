using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3_6TTIRG
{
    internal class Elephant
    {
        private string _nom;
        private uint _tailleOreilles;

        public Elephant(string nom, uint tailleOreilles)
        {
            _nom = nom;
            _tailleOreilles = tailleOreilles;
        }
        public string AfficherQuiJeSuis()
        {
            string chaine = "Je m'appelle " + _nom + " et mes oreilles mesurent " + _tailleOreilles;
            return chaine;
        }
        public void EcouteMessage(string message,Elephant quiDit, Elephant quiRecoit)
        {
            Console.WriteLine(quiRecoit._nom + " a entendu un message de\n" + quiDit._nom + " qui dit : " + message);
        }
        public void EnvoieMessage(string message, Elephant quiRecoit, Elephant quiDit)
        {
            quiRecoit.EcouteMessage(message, this);
        }
        //public void TryParse(string question, out int n)
        //{
        //    string nUser = "";
        //    Console.WriteLine(question);
        //    while (!int.TryParse(nUser, out n))
        //    {
        //        nUser = Console.ReadLine();
        //        Console.WriteLine("Ecris un nombre");
        //    }
        //}
    }
}
