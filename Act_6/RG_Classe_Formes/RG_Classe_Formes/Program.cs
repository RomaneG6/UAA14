namespace RG_Classe_Formes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme[] formes = new Forme[4];

            formes[0] = new Rectangle(10, 7, "noir");
            formes[1] = new Carre(3, "turquoise");
            formes[2] = new Rectangle(364, 731, "bordeau");
            formes[3] = new Carre(399, "bleu marine");

            for (int i = 0; i < formes.Length; i++)
            {
                Console.WriteLine(formes[i].Afficher());
                if (formes[i] is Rectangle rectangle)
                {
                    Console.WriteLine(rectangle.CalculeSurface());
                    Console.WriteLine(rectangle.CalculePerimetre());
                }
                else if (formes[i] is Carre carre)
                {
                    Console.WriteLine(carre.CalculeSurface());
                    Console.WriteLine(carre.CalculePerimetre());
                }
            }
        }
    }
}