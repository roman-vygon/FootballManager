namespace FootballManager
{
    partial class TournamentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentInfo));
            this.matchesList = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.teamsList = new System.Windows.Forms.ListBox();
            this.leftArrowButton = new System.Windows.Forms.Button();
            this.rightArrowButton = new System.Windows.Forms.Button();
            this.stageLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matchesList
            // 
            this.matchesList.BackColor = System.Drawing.SystemColors.Control;
            this.matchesList.FormattingEnabled = true;
            this.matchesList.Location = new System.Drawing.Point(248, 41);
            this.matchesList.Name = "matchesList";
            this.matchesList.Size = new System.Drawing.Size(447, 329);
            this.matchesList.TabIndex = 0;
            this.matchesList.SelectedIndexChanged += new System.EventHandler(this.MatchesList_SelectedIndexChanged);
            this.matchesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MatchesList_MouseDoubleClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // teamsList
            // 
            this.teamsList.BackColor = System.Drawing.SystemColors.Control;
            this.teamsList.FormattingEnabled = true;
            this.teamsList.Location = new System.Drawing.Point(12, 41);
            this.teamsList.Name = "teamsList";
            this.teamsList.Size = new System.Drawing.Size(125, 394);
            this.teamsList.TabIndex = 2;
            // 
            // leftArrowButton
            // 
            this.leftArrowButton.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftArrowButton.Location = new System.Drawing.Point(360, 376);
            this.leftArrowButton.Name = "leftArrowButton";
            this.leftArrowButton.Size = new System.Drawing.Size(50, 50);
            this.leftArrowButton.TabIndex = 3;
            this.leftArrowButton.Text = "⇚";
            this.leftArrowButton.UseVisualStyleBackColor = true;
            this.leftArrowButton.Click += new System.EventHandler(this.LeftArrowButton_Click);
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightArrowButton.Location = new System.Drawing.Point(512, 376);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(50, 50);
            this.rightArrowButton.TabIndex = 4;
            this.rightArrowButton.Text = "⇛";
            this.rightArrowButton.UseVisualStyleBackColor = true;
            this.rightArrowButton.Click += new System.EventHandler(this.RightArrowButton_Click);
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageLabel.Location = new System.Drawing.Point(434, 17);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(46, 18);
            this.stageLabel.TabIndex = 5;
            this.stageLabel.Text = "label1";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 466);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 13);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "timeLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сгенерировать матчи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // TournamentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.rightArrowButton);
            this.Controls.Add(this.leftArrowButton);
            this.Controls.Add(this.teamsList);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.matchesList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentInfo";
            this.Text = "TournamentInfo";
            this.Load += new System.EventHandler(this.TournamentInfo_Load);
            this.Shown += new System.EventHandler(this.TournamentInfo_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox matchesList;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox teamsList;
        private System.Windows.Forms.Button leftArrowButton;
        private System.Windows.Forms.Button rightArrowButton;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button button1;
    }
}