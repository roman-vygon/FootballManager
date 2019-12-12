using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    [Serializable]
    public class Tournament
    {
        public string name { get; private set; }

        int stage = 0;
        bool simulate = false;
        public List<Team> participants { get; private set; } = new List<Team>();
        public List<List<Match>> matches { get; private set; } = new List<List<Match>>();
        List<Int64> stageMaxTimes = new List<Int64>();        
        
        public void checkMatches()
        {
            if (!simulate)
                return;
            int k = 0;
            int unplayedMatches = 0;
            foreach (Match i in matches[stage])
            {

                if (!i.played)
                {
                    unplayedMatches++;
                    if (Storage.time > i.time)
                    {

                        i.played = true;
                        i.playRandom();
                        if (stage != matches.Count - 1)
                            if (k % 2 == 0)
                                matches[stage + 1][k / 2].setFirstTeam(i.winner);
                            else
                                matches[stage + 1][k / 2].setSecondTeam(i.winner);
                    }
                 
                }
                k += 1;
            }
            if (unplayedMatches == 0)
            {
                stage++;
                if (stage >= matches.Count)
                    stage = matches.Count - 1;
            }
        }

        public override string ToString()
        {
            return this.name;
        }

        public void generate()
        {
            Random rnd = new Random();
            participants.OrderBy(a => Guid.NewGuid()).ToList();
            matches.Add(new List<Match>());
            Int64 maxTime = -1;
            for (int i = 0; i < participants.Count / 2; ++i)
            {
                Int64 matchTime = Storage.time + Convert.ToInt64(rnd.Next(5, 15)) * 600000000000;
                maxTime = Math.Max(maxTime, matchTime);
                matches[0].Add(new Match(matchTime, participants[i * 2], participants[i * 2 + 1]));
            }
            stageMaxTimes.Add(maxTime);
            int k = 0;
            while (matches[k].Count > 1)
            {
                maxTime = -1;
                k++;
                matches.Add(new List<Match>());
                for (int i = 0; i < matches[k - 1].Count / 2; ++i)
                {
                    Int64 matchTime = stageMaxTimes[stageMaxTimes.Count - 1] + Convert.ToInt64(rnd.Next(5, 15)) * 600000000000;
                    matches[k].Add(new Match(matchTime, Storage.defaultTeam, Storage.defaultTeam));
                }
            }
        }
        public Tournament(List<Team> teams, string name, bool simulate)
        {
            this.simulate = simulate;
            this.name = name;
            
            this.participants = teams;
            generate();
        }
    }
}
