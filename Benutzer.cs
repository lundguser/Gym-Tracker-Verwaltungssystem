using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Tracker_Verwaltungssystem
{
    public class Benutzer
    {
        public string Username { get; set; }
        public string Passwort { get; set; } = string.Empty;//??
        public string Rolle { get; set; }

        //kapselung damit user und admin doppelte punkte beide nehmen können --> weniger code
    }
}
