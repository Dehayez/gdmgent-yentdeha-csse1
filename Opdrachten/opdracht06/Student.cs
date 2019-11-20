using System;

namespace opdracht6
{
	public class Student : Gebruiker
	{	
		/*******************    FIELDS     *******************/
		/* public string voornaam;
		protected char geslacht; */


		/*******************    PROPERTIES     *******************/
		/* public char Geslacht
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
		} */


		/*******************    CONSTRUCTOR     *******************/
		/* public Persoon() // default constructor
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
		} */


		/*******************    METHODS    *******************/
		/* public void LogOutput()
		{
			Console.WriteLine(String.Format("Persoon: Voornaam: {0}, Familienaam: {1}, Geslacht: {2} \n", this.voornaam, Naam, Geslacht, this.geslacht));
		} */

		
		public Student(string naam, string voornaam, char geslacht) : base(naam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenereerGebruikersnaam();
			this.login = GenereerLogin();
			this.wachtwoord = CreatePasswordHash(GenereerWachtwoord(), CreateSalt());
		}

		private string GenereerGebruikersnaam()
		{
			string fullName = "";
            fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 4);
            return fullName;
		}

		private string GenereerLogin()
		{
			string fullName = "";
            fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 4);
            return fullName + "@student.arteveldehs.be";
		}
		protected new string GenereerWachtwoord()
		{
			string ww = "Stu";
			for (int i = 0; i < 10; i++)
			{
				ww += Convert.ToString(rnd.Next(10));
			}
			return ww + "dent";
		}
		public new void LogOutput()
		{
			Console.WriteLine(string.Format(" - Student: {0}, Login: {1}, Wachtwoord: {2} \n", Gebruikersnaam, Login, Wachtwoord));
		}
	}
}