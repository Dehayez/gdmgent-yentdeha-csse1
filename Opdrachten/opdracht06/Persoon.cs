using System;

namespace opdracht6
{
	public class Persoon
	{
		/*******************    FIELDS     *******************/
		public string voornaam;
		protected char geslacht;


		/*******************    PROPERTIES     *******************/
		public char Geslacht
		{
			get
			{
				return geslacht;
			}
			set
			{
				geslacht = value;
			}
		}

		public string Naam
		{
			get;
			set;
		}


		/*******************    CONSTRUCTOR     *******************/
		public Persoon() // default constructor
		{

		}
		public Persoon(string naam, string voornaam) // constructor naam, voornaam
		{
			Naam = naam;
			this.voornaam = voornaam;
		}
		public Persoon(string naam, string voornaam, char geslacht) // constructor naam, voornaam, geslacht
		{
			Naam = naam;
			this.voornaam = voornaam;
			Geslacht = geslacht;
		}


		/*******************    METHODS    *******************/
		public void LogOutput()
		{
			Console.WriteLine(String.Format("\n - Persoon: Voornaam: {0}, Familienaam: {1}, Geslacht: {2} \n", this.voornaam, Naam, Geslacht, this.geslacht));
		}
	}
}