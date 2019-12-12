using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    [Serializable]
    public class Event
    {
        private int time;
        private Player firstPlayer;
        private Player secondPlayer;
        public string action { get; private set; } = "";
        
        public override string ToString()
        {
            return time.ToString() + ' ' + ((firstPlayer != null) ? firstPlayer.name : " ") + ' ' + action + ' ' + ((secondPlayer != null) ? secondPlayer.name : " ");
        }
        public Event (int time,
                      Player firstPlayer,
                      Player secondPlayer,
                      string action) {
            this.time = time;
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;
            this.action = action;            
        }
    }
}
