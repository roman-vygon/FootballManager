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
    public partial class TeamInfo : Form, InterfaceTime
    {
        private Team team;
        public Label time { get; set; }
        public TeamInfo()
        {
            InitializeComponent();
        }
        public TeamInfo(Team team)
        {
           InitializeComponent();
           this.team = team;
        }

        private void TeamInfo_Load(object sender, EventArgs e)
        {
            time = timeLabel;
            playersList.DisplayMember = "name";
            playersList.DataSource = team.players;
            try
            {
                logoBox.Load(team.logoURL);
            }
            catch (System.Net.WebException exc)
            {

            }
        }

        private void PlayersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.playersList.IndexFromPoint(e.Location);
            Player player = playersList.Items[index] as Player;
            this.Hide();
            PlayerInfo form3 = new PlayerInfo(player);

            form3.Closed += (s, args) => this.Show();
            form3.Closed += TeamInfo_Shown;

            form3.Show();
        }        

        private void TeamInfo_Shown(object sender, EventArgs e)
        {
            Storage.currentForm = this;
        }
    }
}
