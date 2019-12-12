using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    [Serializable]
    public class Match
    {
        public Int64 time { get; private set; }

        public bool played { get;  set; }


        public Team homeTeam { get; private set; }
        public Team guestTeam { get; private set; }

        public Team winner { get; private set; }

        /* События матча */
        public List<Event> events { get; private set; } = new List<Event>();        

        /* Счета команд */
        public int scoreHomeTeam { get; set; } = -1;
        public int scoreGuestTeam { get; set; } = -1;

        /* Счета команд по пенальти */
        public int penaltyHomeTeam { get; set; } = -1;
        public int penaltyGuestTeam { get;set; } = -1;

        
        public void setFirstTeam(Team team)
        {
            this.homeTeam = team;
        }

        public void setSecondTeam(Team team)
        {
            this.guestTeam = team;
        }
        public Match(Int64 time, Team homeTeam, Team guestTeam)
        {
            this.time = time;
            this.homeTeam = homeTeam;
            this.guestTeam = guestTeam;            
        }
        public override string ToString()
        {
            string team1, team2;
            if (homeTeam != null)
                team1 = homeTeam.ToString();
            else
                team1 = "Undecided";

            if (guestTeam != null)
                team2 = guestTeam.ToString();
            else
                team2 = "Undecided";
            return team1 + " - " + team2 + "    " + Convert.ToString(new DateTime(time));            
        }
        private void generateEvents(int num)
        {
            Player holder = homeTeam.players[0];
            Team holdTeam = homeTeam;
            Team otherTeam = guestTeam;
            scoreHomeTeam = 0;
            scoreGuestTeam = 0;
            int time = 0;
            Random rnd = new Random();
            for (int _ = 0; _ < num; _++)
            {

                Event temp;
                time += rnd.Next(1, 5);
                if (time > 90)
                    break;

                switch (rnd.Next(1, 4)) {
                    
                    case 1:
                        Player passesTo = holdTeam.players[rnd.Next(0, holdTeam.players.Count - 1)];
                        temp = new EventBuilder("passes").ball(true).first(holder).second(passesTo).setTime(time).create();
                        events.Add(temp);
                        holder = passesTo;
                        break;
                    case 2:                        
                        Player tackler = otherTeam.players[rnd.Next(0, otherTeam.players.Count - 1)];
                        temp = new EventBuilder("tackles").ball(true).first(tackler).second(holder).setTime(time).create();
                        events.Add(temp);
                        holder = tackler;
                        Team tempTeam = holdTeam;
                        holdTeam = otherTeam;
                        otherTeam = tempTeam;
                        break;
                    case 3:                        
                        bool sc = false;
                        if (rnd.Next(1, 100) > 75)
                            sc = true;
                        Player second = otherTeam.players[rnd.Next(0, otherTeam.players.Count - 1)];
                        temp = new EventBuilder("shoots").ball(false).first(holder).setTime(time).create();
                        events.Add(temp);
                        if (sc)
                        {
                            temp = new EventBuilder("scores").ball(true).first(holder).setTime(time).create();
                            if (holdTeam == homeTeam)
                                scoreHomeTeam++;
                            else
                                scoreGuestTeam++;

                            holder = otherTeam.players[rnd.Next(0, otherTeam.players.Count - 1)];
                            Team tempTeam1 = holdTeam;
                            holdTeam = otherTeam;
                            otherTeam = tempTeam1;
                        }
                        else
                        {
                            temp = new EventBuilder("saves").ball(false).first(otherTeam.goalkeeper).setTime(time).create();
                            holder = otherTeam.goalkeeper;
                            Team tempTeam1 = holdTeam;
                            holdTeam = otherTeam;
                            otherTeam = tempTeam1;
                        }
                        events.Add(temp);
                        break;                    
                }
                
            }
            if (scoreGuestTeam == scoreHomeTeam)
            {
                penaltyGuestTeam = rnd.Next(4, 9);
                if (rnd.Next(1, 100) > 50)
                    penaltyHomeTeam = penaltyGuestTeam + 1;
                else
                    penaltyHomeTeam = penaltyGuestTeam - 1;
            }
        }
        public void playRandom()
        {
            Random rnd = new Random();
            int numEvents = rnd.Next(30, 50);
            generateEvents(numEvents);
            winner = (scoreHomeTeam > scoreGuestTeam || (scoreHomeTeam == scoreGuestTeam && penaltyHomeTeam > penaltyGuestTeam)) ? homeTeam : guestTeam;
        }           
    }
}
