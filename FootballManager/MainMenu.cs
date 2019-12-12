using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FootballManager
{
    
    public partial class MainMenu : Form, InterfaceTime
    {
        public Label time { get; set; }
        private int teamID, tournamentID;
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            time = timeLabel;
            Storage.currentForm = this;            

         

            Storage.defaultTeam = Utility.getTeam("KFC Uerdingen 05");
            Storage.defaultTeam.players.Clear();
            Storage.defaultTeam.setDefaultName();

            try
            {

                Storage.requests = Utility.ReadFromBinaryFile<List<Request>>("requests.pfcsheet");
            }
            catch (FileNotFoundException exception)
            {
             
            }
            try
            {
                
                Storage.teams = Utility.ReadFromBinaryFile<List<Team>>("teams.pfcsheet");
            }
            catch (FileNotFoundException exception)
            {
                Storage.teams.Add(Utility.getTeam("Barcelona"));
                Storage.teams.Add(Utility.getTeam("Inter"));
                Storage.teams.Add(Utility.getTeam("Manchester United"));
                Storage.teams.Add(Utility.getTeam("Manchester City"));
                Storage.teams.Add(Utility.getTeam("Liverpool"));
                Storage.teams.Add(Utility.getTeam("Real Madrid"));
                Storage.teams.Add(Utility.getTeam("Juventus"));
                Storage.teams.Add(Utility.getTeam("Roma"));                
            }

            try { Storage.tournaments = Utility.ReadFromBinaryFile<List<Tournament>>("tournaments.pfcsheet"); }
            catch (FileNotFoundException exception)
            {
                Storage.tournaments.Add(new Tournament(Storage.teams, "UEFA Champions League", true));
            }

            tournamentsList.DataSource = Storage.tournaments;

            Storage.StartTimer();
            teamsList.DataSource = Storage.teams;
        }

        private void TeamsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {   
            int index = this.teamsList.IndexFromPoint(e.Location);
            if (index == -1)
                return;
            Team team = teamsList.Items[index] as Team;

            this.Hide();
            TeamInfo form2 = new TeamInfo(team);            
            form2.Closed += (s, args) => this.Show();
            form2.Closed += MainMenu_Shown;
            form2.Show();
        }

        private void TournamentsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.tournamentsList.IndexFromPoint(e.Location);
            if (index == -1)
                return;
            Tournament tournament = tournamentsList.Items[index] as Tournament;            
            this.Hide();
            TournamentInfo form2 = new TournamentInfo(tournament);
            form2.Closed += (s, args) => this.Show();
            form2.Closed += MainMenu_Shown;
            form2.Show();
        }
        private void MainMenu_Shown(object sender, EventArgs e)
        {
            Storage.currentForm = this;            
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utility.WriteToBinaryFile<List<Tournament>>("tournaments.pfcsheet", Storage.tournaments);
            Utility.WriteToBinaryFile<List<Team>>("teams.pfcsheet", Storage.teams);
            Utility.WriteToBinaryFile<List<Request>>("requests.pfcsheet", Storage.requests);
        }        

        private void ПодатьЗаявкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Request req = new Request(tournamentID, teamsList.Items[teamID] as Team);
            Storage.requests.Add(req);
        }

        private void TournamentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tournamentsList.SelectedIndex != -1)
                tournamentID = tournamentsList.SelectedIndex;
        }

        private void TeamsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamsList.SelectedIndex != -1)
                teamID = teamsList.SelectedIndex;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Storage.tournaments.Add(new Tournament(new List<Team>(), textBox1.Text, false));            
        }

        private void АдминистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration req = new Administration();
            req.Closed += (s, args) => this.Show();
            req.Show();
        }
    }
}
