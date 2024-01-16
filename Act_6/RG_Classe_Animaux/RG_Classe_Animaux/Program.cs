using System.ComponentModel.DataAnnotations;

namespace RG_Classe_Animaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("classe animaux");

            Animal[] animaux = new Animal[5];

            animaux[0] = new Chien("Cerbère", true, 2640, 145, DateTime.Parse("15/01/2000"));
            animaux[1] = new Chien("Artemis", true, 1405, 50, DateTime.Parse("30/12/1980"));
            animaux[2] = new Chat("Aiko", false, 350, 30, DateTime.Parse("04/07/1861"));
            animaux[3] = new Chat("Pipoune", false, 85, 62, DateTime.Parse("18/09/1751"));
            animaux[4] = new Lapin("Pichoune", false, 78045, 15, DateTime.Parse("27/02/2078"),180);

            for (int i = 0; i < animaux.Length; i++)
            {
                Console.WriteLine(animaux[i].Afficher());
                Console.WriteLine(animaux[i].Manger());
                Console.WriteLine(animaux[i].Dormir());
                if (animaux[i] is Chien chien)
                {
                    Console.WriteLine(chien.Aboyer());
                }
                else if (animaux[i] is Chat chat)
                {
                    Console.WriteLine(chat.Miauler());
                    Console.WriteLine(chat.Ronronner());
                }
                else if (animaux[i] is Lapin lapin)
                {
                    Console.WriteLine(lapin.Afficher());
                    Console.WriteLine(lapin.Bondir());
                }
            }
        }
    }
}