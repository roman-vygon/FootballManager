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
    public partial class TournamentInfo : Form, InterfaceTime
    {
        private Tournament tournament;
        private int currentStage = 0;
        public Label time { get; set; }
        public TournamentInfo(Tournament tournament)
        {
            InitializeComponent();
            this.tournament = tournament;
        }

        private void LeftArrowButton_Click(object sender, EventArgs e)
        {
            currentStage -= 1;
            if (currentStage < 0)
                currentStage = 0;
            setDataSource();
        }
        private void setDataSource()
        {
            matchesList.DataSource = tournament.matches[currentStage];
            stageLabel.Text = "Stage " + (currentStage+1).ToString();
        }
        private void RightArrowButton_Click(object sender, EventArgs e)
        {
            currentStage += 1;
            currentStage %= tournament.matches.Count;
            setDataSource();
        }

        private void TournamentInfo_Load(object sender, EventArgs e)
        {
            time = timeLabel;
            setDataSource();
            teamsList.DataSource = tournament.participants;
            nameLabel.Text = tournament.name;
        }

        private void TournamentInfo_Shown(object sender, EventArgs e)
        {
            Storage.currentForm = this;
        }

        private void MatchesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MatchesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.matchesList.IndexFromPoint(e.Location);
            if (index == -1)
                return;
            Match match = matchesList.Items[index] as Match;
            this.Hide();
            MatchInfo form2 = new MatchInfo(match);
            form2.Closed += (s, args) => this.Show();
            form2.Closed += TournamentInfo_Shown;
            form2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Match match = matchesList.Items[matchesList.SelectedIndex] as Match;
          
        }
    }
}
