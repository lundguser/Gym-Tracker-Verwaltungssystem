using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Tracker_Verwaltungssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //User Objekte (vorerst Hardcode)
            Benutzer user1 = new Benutzer();
            user1.Username = "Johnny";
            user1.Password = "123";
            user1.Rolle = "User";

            Benutzer user2 = new Benutzer();
            user2.Username = "Jack";
            user2.Password = "1234";
            user2.Rolle = "User";

            Benutzer user3 = new Benutzer();
            user3.Username = "Tyleel";
            user3.Password = "12345";
            user3.Rolle = "User";


            //Admin Objekt  (vorerst hardcode)
            Admin admin1 = new Admin();
            admin1.Username = "admin";
            admin1.Password = "master";
            admin1.Rolle = "Admin";


            //Liste hinzugefügt (muss unter den usern sein sonst fehler)
            List<Benutzer> alleUser = new List<Benutzer>();
            alleUser.Add(user1);
            alleUser.Add(user2);
            alleUser.Add(user3);
            alleUser.Add(admin1);


            //login test
            Console.WriteLine("Willkomen Im Gym Tracker!\nBitte logge dich ein!");
            Console.WriteLine("Benutzername:");
            string nameEingabe = Console.ReadLine();
            
            Console.WriteLine("Passwort");
            string pwEingabe = Console.ReadLine();

            //überprüfen ob es den user gibt
            bool userExistiert = false;

            foreach (Benutzer B in alleUser)
            {
                
                if (B.Username == nameEingabe)
                {
                    userExistiert = true;
                    gefundenerUser = B;
                    break;
                }


            }

            if (userExistiert == false)
            {
                Console.WriteLine("Dieser Username existiert nicht...");
            }
            else
            {
                if (gefundenerUser.Passwort == pwEindgabe)
                {
                    Console.WriteLine("Erfolgreich eingeloggt!");

                    if (gefundenerUser.Rolle == "Admin")
                    {
                        Console.WriteLine("Willkommen im Admin-Menü");
                    }
                    else
                    {
                        Console.WriteLine("Willkommen im User-Menü");
                    }
                }
                else
                {
                    Console.WriteLine("Falsches Passwort.");
                }
            }

            */
            Benutzer user1 = new Benutzer("jack5", "coke23", 69);
            Benutzer user2 = new Benutzer("lox", "karotte123", 4); login(user1, user2);
        }
        static void login(Benutzer user1, Benutzer user2)
        {
            Console.WriteLine("Willkommen im Gym Tracker!\nBitte melden sie sich an!"); 
            Console.Write("Username: "); 
            string inputUsername = Console.ReadLine(); 
            Console.Write("Password: "); 
            string inputPassword = Console.ReadLine(); 
            
            if ((inputUsername == user1.Username && inputPassword == user1.Password) || (inputUsername == user2.Username && inputPassword == user2.Password)) 
            { 
                Console.WriteLine("Sie haben sich erfolgreich eingeloggt"); 
            } 
            else 
            { 
                Console.WriteLine("Benutzername und/oder Passwort ist falsch"); 
            }


        }
    }
}
