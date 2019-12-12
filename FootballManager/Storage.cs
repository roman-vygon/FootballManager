using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FootballManager
{
    static class Storage
    {
        static public List<Team> teams = new List<Team>();
        static public List<Tournament> tournaments = new List<Tournament>();
        static public InterfaceTime currentForm;
        private static object lockObject = new object();
        public static Int64 time = 634684800000000000;
        private static System.Threading.Timer gAppTimer;
        static public Team defaultTeam;
        static public List<Request> requests = new List<Request>();
        public static void StartTimer()
        {
            if (gAppTimer == null)
            {
                lock (lockObject)
                {
                    if (gAppTimer == null)
                    {
                        
                        gAppTimer = new System.Threading.Timer(OnTimerTick, null, 0, 200);
                    }
                }
            }
        }

        public static void StopTimer()
        {
            if (gAppTimer != null)
            {
                lock (lockObject)
                {
                    if (gAppTimer != null)
                    {
                        gAppTimer.Change(Timeout.Infinite, Timeout.Infinite);
                        gAppTimer = null;
                    }
                }
            }
        }
        delegate void changeTextDelegate(Control ctrl, string text);
        public static void changeText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                try
                {
                    changeTextDelegate del = new changeTextDelegate(changeText);
                    ctrl.Invoke(del, ctrl, text);
                }
                catch ( ObjectDisposedException e)
                {

                }
            }
            else
            {
                ctrl.Text = text;
            }
        }
        private static void OnTimerTick(object state)
        {
            Storage.time += 100000000000;
            if (currentForm.time != null)
                changeText(currentForm.time, Convert.ToString(new DateTime(Storage.time)));
            foreach (Tournament t in tournaments)
            {
                t.checkMatches();
            }
        }
    }

  
}
