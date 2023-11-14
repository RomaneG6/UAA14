using Act3_6TTIRG;

internal class Program
{
    private static void Main(string[] args)
    {
        uint choix = 0;
        string again = "oui";
        string message = "";
        uint destinataire = 0;

        Random alea = new Random();
        Elephant e1 = new Elephant("Zazou", (uint)alea.Next(50,100));
        Elephant e2 = new Elephant("Titi", (uint)alea.Next(50, 100));
        Elephant bulle;
        Elephant quiDit;
        Elephant quiRecoit;

        while (again == "oui") 
        {
            Console.WriteLine("Choisissez entre 1,2 et 3");
            choix = uint.Parse(Console.ReadLine());
            if (choix == 1)
            {
                Console.WriteLine(e1.AfficherQuiJeSuis());
            }
            else if (choix == 2)
            {
                Console.WriteLine(e2.AfficherQuiJeSuis());
            }
            else if (choix == 3)
            {
                bulle = e1;
                e1 = e2;
                e2 = bulle;

                Console.WriteLine(e1.AfficherQuiJeSuis());
                Console.WriteLine(e2.AfficherQuiJeSuis());
            }
            else if (choix == 4)
            {
                Console.WriteLine("Choisissez le destinataire du message :");
                destinataire = uint.Parse(Console.ReadLine());
                if (destinataire == 1)
                {
                    Console.WriteLine(e2.EcouteMessage("Coucou !", e1));
                }
                else if (destinataire == 2)
                {
                    quiDit = e2;
                }


            }
            Console.WriteLine("Voulez vous recommencer?");
            again = Console.ReadLine();
        }
    }
}