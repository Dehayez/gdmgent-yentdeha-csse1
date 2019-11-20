using System;

namespace opdracht6
{
	public class Docent : Gebruiker
	{
		public Docent(string naam, string voornaam, char geslacht) : base (naam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenereerGebruikersnaam();
			this.login = GenereerLogin();
			this.wachtwoord = CreatePasswordHash(GenereerWachtwoord(), CreateSalt());
		}

		private string GenereerGebruikersnaam()
		{
			string fullName = "";
			fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 2);
            return fullName;
		}

		private string GenereerLogin()
		{
			string fullName = "";
			fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 2);
            return fullName + "@arteveldehs.be";
		}
		protected new string GenereerWachtwoord()
		{
			string ww = "Do";
			for (int i = 0; i < 10; i++)
			{
				ww += Convert.ToString(rnd.Next(10));
			}
			return ww + "cent";
		}
		public new void LogOutput()
		{
			Console.WriteLine(string.Format(" - Docent: {0}, Login: {1}, Wachtwoord: {2} \n", Gebruikersnaam, Login, Wachtwoord));
		}
	}
}