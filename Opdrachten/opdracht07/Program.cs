using System;

namespace opdracht6
{
    class Program
    {
        void Main(string[] args)
        {
            Persoon persoon = new Persoon("Vanhoecke", "Lisa", 'V');
            persoon.LogOutput();

            Gebruiker gebruiker = new Gebruiker("Vermeer", "Lucas", 'M');
            gebruiker.LogOutput();

            Student student = new Student("Vertongen", "Jantje", 'M');
            student.LogOutput();

            Docent docent = new Docent("Vandamme", "Martin", 'O');
            docent.LogOutput();
        }
    }
}