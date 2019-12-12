using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{   [Serializable]
    class Request
    {
        public int tournament_id { get; private set; }
        public Team team { get; private set; }
        public bool approved = false;

        public void approve()
        {
            Storage.tournaments[tournament_id].participants.Add(team);
        }
        public Request (int tournament_id, Team team)
        {
            this.tournament_id = tournament_id;
            this.team = team;
        }
        public override string ToString()
        {
            return Storage.tournaments[tournament_id].ToString() + " : " + team.ToString();
        }
    }
}
