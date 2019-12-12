using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager
{
    public partial class EventsList : Form, InterfaceTime
    {
        private Match match;
        public Label time { get; set; }
        public EventsList(Match match)
        {
            InitializeComponent();
            this.match = match;
        }

        private void EventsList_Load(object sender, EventArgs e)
        {
            time = timeLabel;
            eventList.DataSource = match.events;
            

        }

        private void EventList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EventsList_Shown(object sender, EventArgs e)
        {
            Storage.currentForm = this;
        }

        private void EventList_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Get row of List Box  
            if (e.Index == -1)
                return;
            
            Event listBoxEvent = (Event)eventList.Items[e.Index];
            e.DrawBackground();
            
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);            
            if (listBoxEvent.action.ToString().Contains("pass"))
                g.DrawImage(imageList1.Images["pass"], rec);
            else if (listBoxEvent.action.ToString().Contains("score"))
                g.DrawImage(imageList1.Images["score"], rec);
            else if (listBoxEvent.action.ToString().Contains("save"))
                g.DrawImage(imageList1.Images["save"], rec);
            else if (listBoxEvent.action.ToString().Contains("tackle"))
                g.DrawImage(imageList1.Images["tackle"], rec);
            else if (listBoxEvent.action.ToString().Contains("shoot"))
                g.DrawImage(imageList1.Images["shoot"], rec);
            Point p = new Point(e.Bounds.X + e.Bounds.Height, e.Bounds.Y);
            e.Graphics.DrawString(listBoxEvent.ToString(), e.Font, new SolidBrush(Color.Black), p);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            EventCreator testDialog = new EventCreator(match);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                EventBuilder temp = new EventBuilder(testDialog.action).setTime(testDialog.time);
                if (testDialog.firstPlayer != null)
                    temp.first(testDialog.firstPlayer);
                if (testDialog.secondPlayer != null)
                    temp.second(testDialog.secondPlayer);
                match.events.Add(temp.create());
            }
            testDialog.Dispose();
        }
    }
}
