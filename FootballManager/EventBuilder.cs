using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    class EventBuilder
    {

        int time;
        Player firstPlayer;
        Player secondPlayer;
        string action;        
        bool ballPasses;                

        public EventBuilder(string action)
        {
            this.action = action;
            
        }

        public EventBuilder first(Player player)
        {
            this.firstPlayer = player;
            return this;
        }

        public EventBuilder second(Player player)
        {
            this.secondPlayer = player;
            return this;
        }
        public EventBuilder ball(bool passes)
        {
            this.ballPasses = passes;
            return this;
        }
        public EventBuilder setTime(int time)
        {
            this.time = time;
            return this;
        }
        public Event create()
        {
            return new Event(time, firstPlayer, secondPlayer, action);
        }
    }
}
