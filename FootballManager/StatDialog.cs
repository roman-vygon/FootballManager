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
    public partial class StatDialog : Form
    {
        public int scoreHome { get; set; }
        public int scoreGuest { get; set; }
        public int penaltyHome { get; set; }
        public int penaltyGuest { get; set; }


        public StatDialog(Match match)
        {
            this.scoreGuest = match.scoreGuestTeam;
            this.scoreHome = match.scoreHomeTeam;
            this.penaltyGuest = match.penaltyGuestTeam;
            this.penaltyHome = match.penaltyHomeTeam;

            InitializeComponent();


            homeLabel.Text = match.homeTeam.name;
            guestLabel.Text = match.guestTeam.name;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.scoreGuest = Convert.ToInt32(guestScoreTextbox.Text);
            if (guestPenaltyTextbox.Text.Length != 0)
                this.penaltyGuest = Convert.ToInt32(guestPenaltyTextbox.Text);

            this.scoreHome = Convert.ToInt32(homeScoreTextbox.Text);
            if (homePenaltyTextbox.Text.Length != 0)
                this.penaltyHome = Convert.ToInt32(homePenaltyTextbox.Text);
        }
    }
}
