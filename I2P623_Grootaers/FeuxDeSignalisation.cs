using System;

public class Feux
{
	public Feux()
	{
		string _nom;
		int _couleur;

	public string Nom
	{
		get { return _nom; }
	}

	public int Couleur
	{
		get { return _couleur; }
		set { _couleur = value; }
	}

	public bool Clignoter(bool clignotant)
	{
		if (clignotant = false)
		{
			chaine ="Le "+ nom +"est éteint"
		}
		else
		{
            chaine = "Le " + nom + "est allumé"

        }
		return chaine
	}

	}
}
