using System;
namespace POOExChien
{
    class Program
    {

        private static void Main(string[] args)
        {
            Chien chien1 = new Chien("Garry", "Teckel", 10, true, true, "male", true);
            Chien chien2 = new Chien("Tokyo", "Shiba Inu", 1, true, true, "male", true);
            Chien chien3 = new Chien("Oka", "Border Collie", 2, true, true, "female", true);
            string nom;
            string race;
            uint age;
            bool vaccin;
            bool puce; 
            string genre;
            bool sterile;

            chien1.AfficheCarac();
            chien2.AfficheCarac();
            chien3.AfficheCarac();

            Chien[] MesChiens = new Chien[] { chien1, chien2, chien3 };
        }
    }
}