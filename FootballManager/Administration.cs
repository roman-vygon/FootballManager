﻿using System;
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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            requestListBox.DataSource = Storage.requests;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Request req = requestListBox.SelectedItem as Request;
            req.approve();
        }
    }
}
