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
    public partial class EventCreator : Form
    {
        public Player firstPlayer { get; set; } = null;
        public Player secondPlayer { get; set; } = null;
        public int time { get; set; }
        public string action { get; set; }
        private Match match;
        public EventCreator(Match match)
        {
            this.match = match;
            InitializeComponent();
        }

        private void EventCreator_Load(object sender, EventArgs e)
        {
            homeTeamList.DataSource = match.homeTeam.players;
            guestTeamList.DataSource = match.guestTeam.players;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.time = Convert.ToInt32(timeTextBox.Text);
            this.action = actionTextBox.Text;              
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (homeTeamList.SelectedIndex != -1)
                this.secondPlayer = homeTeamList.SelectedItem as Player;

            if (guestTeamList.SelectedIndex != -1)
                this.secondPlayer = guestTeamList.SelectedItem as Player;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (homeTeamList.SelectedIndex != -1)
                this.firstPlayer = homeTeamList.SelectedItem as Player;

            if (guestTeamList.SelectedIndex != -1)
                this.firstPlayer = guestTeamList.SelectedItem as Player;
        }
    }
}
