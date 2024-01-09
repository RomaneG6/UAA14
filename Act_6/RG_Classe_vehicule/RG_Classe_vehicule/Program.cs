namespace RG_Classe_vehicule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule_CB Vehicule1 = new Vehicule_CB("Land-Rover", "Discovery sport", "blanche", 50000);
            Velo_CD velo1 = new Velo_CD("ville", true, "Motobecane", "Discovery sport", "noir", 1200);
            Voiture_CD voiture1 = new Voiture_CD("blabla", true, "ouais", "Toyota", "vert", 35000);
            Console.WriteLine("Bienvenue !");
            Console.WriteLine("Info :\n");
            string info = Vehicule1.Afficher();
            Console.WriteLine("Info :\n");
            info = velo1.Afficher();
            Console.WriteLine("Info :\n");
            info = voiture1.Afficher();
        }
    }
}