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
    public partial class PlayerInfo : Form, InterfaceTime
    {
        private Player player;
        public Label time { get; set; }
        public PlayerInfo(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void PlayerInfo_Load(object sender, EventArgs e)
        {
            time = timeLabel;
            nameLabel.Text = player.name;
            nationalityLabel.Text = player.nationality;
            heightLabel.Text = player.height;
            weightLabel.Text = player.weight;
            footLabel.Text = player.foot;
            staminaLabel.Text = Convert.ToString(player.stamina);
            ratingLabel.Text = Convert.ToString(player.overall);
            potentialLabel.Text = Convert.ToString(player.potential);
            try
            {
                photoBox.Load(player.photoURL);
            }
            catch(Exception ex)
            {
                player.changePhoto(player.photoURL.Replace("/10/", "/4/"));
                try
                {
                    photoBox.Load(player.photoURL);
                }
                catch(Exception ex1)
                {
                    try
                    {
                        photoBox.Load("https://cdn.sofifa.org/players/10/notfound_0.png");
                    }
                    catch (System.Net.WebException ex2)
                    {

                    }
                }
            }
            try
            {
                flagBox.Load(player.flagURL);
            }
            catch  (System.Net.WebException exc3) { }
            photoBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PlayerInfo_Shown(object sender, EventArgs e)
        {
            Storage.currentForm = this;
        }
    }
}
