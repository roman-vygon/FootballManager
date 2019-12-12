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
    public partial class MatchInfo : Form, InterfaceTime
    {
        public Label time { get; set; }
        private Match match;
        public MatchInfo(Match match)
        {
            InitializeComponent();
            this.match = match;
        }

        private void MatchInfo_Load(object sender, EventArgs e)
        {
            time = timeLabel;            
            homeTeamName.Text = match.homeTeam.name;
            guestTeamName.Text = match.guestTeam.name;
            homeTeamLogo.Load(match.homeTeam.logoURL);
            guestTeamLogo.Load(match.guestTeam.logoURL);
            dateLabel.Text = Convert.ToString(new DateTime(match.time));

            string score1, score2, penaltyScore1, penaltyScore2;
            if (match.scoreHomeTeam != -1)
            {
                score1 = match.scoreHomeTeam.ToString();
                score2 = match.scoreGuestTeam.ToString();
            }
            else            
                score1 = score2 = "-";
            if (match.penaltyGuestTeam != -1)
            {
                penaltyScore1 = match.penaltyHomeTeam.ToString();
                penaltyScore2 = match.penaltyGuestTeam.ToString();
            }
            else
                penaltyScore1 = penaltyScore2 = "-";
            scoreLabel.Text = score1 + " : " + score2;
            penaltyLabel.Text = penaltyScore1 + " : " + penaltyScore2;

            guestTeamPlayersList.DataSource = match.guestTeam.players;
            homeTeamPlayersList.DataSource = match.homeTeam.players;
        }

        private void КомандыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventsList form2 = new EventsList(match);
            form2.Closed += (s, args) => this.Show();
            form2.Closed += MatchInfo_Shown;
            form2.Show();
        }

        private void MatchInfo_Shown(object sender, EventArgs e)
        {
            Storage.currentForm = this;
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            StatDialog testDialog = new StatDialog(match);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                match.penaltyGuestTeam = testDialog.penaltyGuest;
                match.penaltyHomeTeam = testDialog.penaltyHome;
                match.scoreGuestTeam = testDialog.scoreGuest;
                match.scoreHomeTeam = testDialog.scoreHome;
            }            
            testDialog.Dispose();
        }
    }
}
