using System;
namespace POOExChien
{
    class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("première méthode");
            Chien chien1 = new Chien("Napoléon", "Labrador", 6);
            Chien chien2 = new Chien("Oka", "Berger Australien", 1);
            Chien chien3 = new Chien("Xena", "Bulldog", 3);

            Console.WriteLine(chien1.AfficherCarac());
            Console.WriteLine(chien2.AfficherCarac());
            Console.WriteLine(chien3.AfficherCarac());
        }
    }
}