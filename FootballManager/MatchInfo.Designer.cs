namespace FootballManager
{
    partial class MatchInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchInfo));
            this.homeTeamLogo = new System.Windows.Forms.PictureBox();
            this.guestTeamLogo = new System.Windows.Forms.PictureBox();
            this.homeTeamName = new System.Windows.Forms.Label();
            this.guestTeamName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.командыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeTeamPlayersList = new System.Windows.Forms.ListBox();
            this.guestTeamPlayersList = new System.Windows.Forms.ListBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTeamLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeTeamLogo
            // 
            this.homeTeamLogo.Location = new System.Drawing.Point(12, 56);
            this.homeTeamLogo.Name = "homeTeamLogo";
            this.homeTeamLogo.Size = new System.Drawing.Size(150, 150);
            this.homeTeamLogo.TabIndex = 0;
            this.homeTeamLogo.TabStop = false;
            // 
            // guestTeamLogo
            // 
            this.guestTeamLogo.Location = new System.Drawing.Point(350, 56);
            this.guestTeamLogo.Name = "guestTeamLogo";
            this.guestTeamLogo.Size = new System.Drawing.Size(150, 150);
            this.guestTeamLogo.TabIndex = 2;
            this.guestTeamLogo.TabStop = false;
            // 
            // homeTeamName
            // 
            this.homeTeamName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamName.Location = new System.Drawing.Point(12, 209);
            this.homeTeamName.Name = "homeTeamName";
            this.homeTeamName.Size = new System.Drawing.Size(150, 21);
            this.homeTeamName.TabIndex = 3;
            this.homeTeamName.Text = "label1";
            this.homeTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guestTeamName
            // 
            this.guestTeamName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestTeamName.Location = new System.Drawing.Point(350, 209);
            this.guestTeamName.Name = "guestTeamName";
            this.guestTeamName.Size = new System.Drawing.Size(150, 21);
            this.guestTeamName.TabIndex = 4;
            this.guestTeamName.Text = "label2";
            this.guestTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.командыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // командыToolStripMenuItem
            // 
            this.командыToolStripMenuItem.Name = "командыToolStripMenuItem";
            this.командыToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.командыToolStripMenuItem.Text = "События";
            this.командыToolStripMenuItem.Click += new System.EventHandler(this.КомандыToolStripMenuItem_Click);
            // 
            // homeTeamPlayersList
            // 
            this.homeTeamPlayersList.FormattingEnabled = true;
            this.homeTeamPlayersList.Location = new System.Drawing.Point(12, 257);
            this.homeTeamPlayersList.Name = "homeTeamPlayersList";
            this.homeTeamPlayersList.Size = new System.Drawing.Size(150, 186);
            this.homeTeamPlayersList.TabIndex = 6;
            // 
            // guestTeamPlayersList
            // 
            this.guestTeamPlayersList.FormattingEnabled = true;
            this.guestTeamPlayersList.Location = new System.Drawing.Point(350, 257);
            this.guestTeamPlayersList.Name = "guestTeamPlayersList";
            this.guestTeamPlayersList.Size = new System.Drawing.Size(150, 186);
            this.guestTeamPlayersList.TabIndex = 7;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(178, 86);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(156, 73);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "0 : 0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 464);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 13);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "label2";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(232, 430);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "label3";
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Location = new System.Drawing.Point(241, 159);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(35, 13);
            this.penaltyLabel.TabIndex = 11;
            this.penaltyLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Изменить счет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MatchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.penaltyLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.guestTeamPlayersList);
            this.Controls.Add(this.homeTeamPlayersList);
            this.Controls.Add(this.guestTeamName);
            this.Controls.Add(this.homeTeamName);
            this.Controls.Add(this.guestTeamLogo);
            this.Controls.Add(this.homeTeamLogo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MatchInfo";
            this.Text = "MatchInfo";
            this.Load += new System.EventHandler(this.MatchInfo_Load);
            this.Shown += new System.EventHandler(this.MatchInfo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTeamLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox homeTeamLogo;
        private System.Windows.Forms.PictureBox guestTeamLogo;
        private System.Windows.Forms.Label homeTeamName;
        private System.Windows.Forms.Label guestTeamName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem командыToolStripMenuItem;
        private System.Windows.Forms.ListBox homeTeamPlayersList;
        private System.Windows.Forms.ListBox guestTeamPlayersList;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label penaltyLabel;
        private System.Windows.Forms.Button button1;
    }
}