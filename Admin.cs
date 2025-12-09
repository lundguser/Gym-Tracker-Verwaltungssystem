using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Tracker_Verwaltungssystem
{
    public class Admin : Benutzer //hier kommt ncoh was hin von vererbung 
    {
        public Admin(string username, string password, int alter) : base(username, password, alter)
        {
        }


        public void BenutzerAnzeigen(List<Benutzer> benutzerListe)
        {
            Console.WriteLine("\n=== Benutzerliste ===");
            foreach (Benutzer b in benutzerListe)
            {
                string rolle;

                if (b is Admin)
                {
                    rolle = "Admin";
                }
                else
                {
                    rolle = "Benutzer";
                }

                Console.WriteLine($"- {b.Username} ({rolle})");
            }

        }

        public void BenutzerAnlegen(List<Benutzer> benutzerListe)
        {
            Console.Write("\nNeuer Benutzername: ");
            string name = Console.ReadLine();

            Console.Write("Passwort: ");
            string pw = Console.ReadLine();

            Console.Write("Alter: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            Benutzer neu = new Benutzer(name, pw, alter);
            benutzerListe.Add(neu);

            Console.WriteLine("Benutzer erfolgreich angelegt!");
        }

        public void BenutzerLöschen(List<Benutzer> benutzerListe)
        {
            Console.Write("\nBenutzername zum Löschen eingeben: ");
            string name = Console.ReadLine();

            Benutzer ziel = null;

            foreach (Benutzer benutzer in benutzerListe)
            {
                if (benutzer.Username == name)
                {
                    ziel = benutzer; 
                    break;
                }
            }
                

            if (ziel == null)
            {
                Console.WriteLine("Benutzer nicht gefunden.");
                return;
            }

            if (ziel is Admin)
            {
                Console.WriteLine("Ein Admin kann nicht gelöscht werden!");
                return;
            }

            benutzerListe.Remove(ziel);
            Console.WriteLine("Benutzer wurde gelöscht.");
        }
           

    }
}
