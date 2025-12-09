using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Wichtig für File.WriteAllLines

namespace Gym_Tracker_Verwaltungssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Benutzer erstellen
            Benutzer user1 = new Benutzer("jack5", "coke23", 50);

            Benutzer user2 = new Benutzer("lox", "karotte123", 20);

            //Admin erstellen
            Admin admin = new Admin("admin", "themaster1", 30);

            // Liste aller Benutzer
            List<Benutzer> benutzerListe = new List<Benutzer>();
            benutzerListe.Add(user1);
            benutzerListe.Add(user2);
            benutzerListe.Add(admin);

            //Login starten
            Login(benutzerListe);
        }



        //Login Methode
        static void Login(List<Benutzer> benutzerListe)
        {
            Console.WriteLine("Willkommen im Gym Tracker!\nBitte melden sie sich an!");

            Console.Write("\nUsername: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Password: ");
            string inputPassword = Console.ReadLine();

            Benutzer gefundenerUser = null;


            //Liste wird durchsucht     Jeder Benutzer wird geprüft
            foreach (Benutzer aktuellerBenutzer in benutzerListe)
            {
                if (aktuellerBenutzer.Username == inputUsername &&
                    aktuellerBenutzer.Password == inputPassword)
                {
                    gefundenerUser = aktuellerBenutzer;
                    break;
                }
            }

            //Keine Übereinstimmung --> login failed
            if (gefundenerUser == null) // =wenn User nicht gefunden wurde
            {
                Console.WriteLine("Benutzername und/oder Passwort falsch.");
                return;
            }

            Console.WriteLine($"Eingeloggt als: {gefundenerUser.Username}");


            //Weiterleitung an jeweilige Rolle
            if (gefundenerUser is Admin)
            {
                AdminMenü((Admin)gefundenerUser, benutzerListe);
            }
            else
            {
                BenutzerMenü(gefundenerUser);
            }
        }




        //Benutzer Menü Methode
        static void BenutzerMenü(Benutzer user)
        {
            bool aktiv = true;

            while (aktiv)
            {
                Console.WriteLine("\n\n=========================");
                Console.WriteLine("======= Hauptmenü =======");
                Console.WriteLine("= 1. Heutiges Training ");
                Console.WriteLine("= 2. Training hinzufügen ");
                Console.WriteLine("= 3. Logout ");
                Console.Write("= Bitte wählen:  ");
                string auswahl = Console.ReadLine();




                switch (auswahl)
                {
                    case "1":
                        TrainingAnzeigen(user);
                        break;

                    case "2":
                        TrainingHinzufügen(user);
                        break;

                    case "3":
                        aktiv = false;
                        Console.WriteLine("\nSie wurden ausgeloggt. ");
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        break;
                }
            }
        }


        // Training Anzeigen Methode
        static void TrainingAnzeigen(Benutzer user)
        {
            string dateiName = $"{user.Username}.txt";

            if (!File.Exists(dateiName))
            {
                Console.WriteLine("Noch keine Einträge vorhanden ");
                return;
            }

            Console.WriteLine("\n=========================");
            Console.WriteLine("=== Trainingseinträge ===");

            foreach (string zeile in File.ReadAllLines(dateiName))
            {
                Console.WriteLine(zeile);
            }
        }



        // Training Hinzufügen Methode
        static void TrainingHinzufügen(Benutzer user)
        {
            Console.WriteLine("\nTraining hinzufügen:");
            string neuerEintrag = Console.ReadLine();

            string dateiName = $"{user.Username}.txt";

            File.AppendAllLines(dateiName, new List<string>() { neuerEintrag });  //fügt eine neue Zeile Text zur Datei hinzu oder erstellt die Datei falls noch nicht vorhanden
            Console.WriteLine("Training hinzugefügt.");
        }



        // Admin Menü Methode
        static void AdminMenü(Admin admin, List<Benutzer> benutzerListe)
        {
            bool aktiv = true;

            while (aktiv)
            {
                Console.WriteLine("\n\n=========================");
                Console.WriteLine("======= Admin Menü =======");
                Console.WriteLine("= 1. Benutzer anzeigen ");
                Console.WriteLine("= 2. Benutzer anlegen ");
                Console.WriteLine("= 3. Benutzer löschen ");
                Console.WriteLine("= 4. Logout");
                Console.Write("= Bitte wählen:  ");

                string auswahl = Console.ReadLine();



                switch (auswahl)
                {
                    case "1":
                        admin.BenutzerAnzeigen(benutzerListe);
                        break;

                    case "2":
                        admin.BenutzerAnlegen(benutzerListe);
                        break;

                    case "3":
                        admin.BenutzerLöschen(benutzerListe);
                        break;

                    case "4":
                        aktiv = false;
                        Console.WriteLine("\nSie wurden ausgeloggt. ");
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        break;
                }
            }
        }
    }
}





  
