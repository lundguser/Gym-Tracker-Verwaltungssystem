using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Tracker_Verwaltungssystem
{
    public class Benutzer
    {
        //kapselung damit user und admin doppelte punkte beide nehmen können --> weniger code
        public string Username { get; set; }
        public string Password { get; set; }
        public int Alter { get; set; }
        public Benutzer(string username, string password, int alter)
        {
            Username = username;
            Password = password; Alter = alter;
        }
    }
}
    
    

