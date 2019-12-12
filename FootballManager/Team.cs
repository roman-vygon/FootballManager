using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    [Serializable]
    public class Team
    {
        public override string ToString()
        {
            return this.name;
        }
        public string name { get; private set; }    

        public void setDefaultName()
        {
            name = "Undecided";
        }
        public Player goalkeeper { get; private set; }
        public string logoURL { get; private set; }
        public List<Player> players { get; private set; }
        public Team(string name,  string logoURL, List<Player> players, Player goalkeeper)
        {
            this.goalkeeper = goalkeeper;
            this.name = name;
            this.logoURL = logoURL;
            this.players = players;
        }
    }
}
