namespace FootballManager
{
    partial class StatDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatDialog));
            this.homeLabel = new System.Windows.Forms.Label();
            this.guestLabel = new System.Windows.Forms.Label();
            this.homeScoreTextbox = new System.Windows.Forms.TextBox();
            this.guestScoreTextbox = new System.Windows.Forms.TextBox();
            this.homePenaltyTextbox = new System.Windows.Forms.TextBox();
            this.guestPenaltyTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Location = new System.Drawing.Point(12, 47);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(35, 13);
            this.homeLabel.TabIndex = 2;
            this.homeLabel.Text = "label1";
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Location = new System.Drawing.Point(328, 47);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(35, 13);
            this.guestLabel.TabIndex = 3;
            this.guestLabel.Text = "label2";
            // 
            // homeScoreTextbox
            // 
            this.homeScoreTextbox.Location = new System.Drawing.Point(12, 63);
            this.homeScoreTextbox.Name = "homeScoreTextbox";
            this.homeScoreTextbox.Size = new System.Drawing.Size(100, 20);
            this.homeScoreTextbox.TabIndex = 4;
            // 
            // guestScoreTextbox
            // 
            this.guestScoreTextbox.Location = new System.Drawing.Point(263, 63);
            this.guestScoreTextbox.Name = "guestScoreTextbox";
            this.guestScoreTextbox.Size = new System.Drawing.Size(100, 20);
            this.guestScoreTextbox.TabIndex = 5;
            // 
            // homePenaltyTextbox
            // 
            this.homePenaltyTextbox.Location = new System.Drawing.Point(12, 89);
            this.homePenaltyTextbox.Name = "homePenaltyTextbox";
            this.homePenaltyTextbox.Size = new System.Drawing.Size(100, 20);
            this.homePenaltyTextbox.TabIndex = 6;
            // 
            // guestPenaltyTextbox
            // 
            this.guestPenaltyTextbox.Location = new System.Drawing.Point(263, 89);
            this.guestPenaltyTextbox.Name = "guestPenaltyTextbox";
            this.guestPenaltyTextbox.Size = new System.Drawing.Size(100, 20);
            this.guestPenaltyTextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Основное время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пенальти";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(288, 167);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 10;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // StatDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 202);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guestPenaltyTextbox);
            this.Controls.Add(this.homePenaltyTextbox);
            this.Controls.Add(this.guestScoreTextbox);
            this.Controls.Add(this.homeScoreTextbox);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.homeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatDialog";
            this.Text = "Укажите счет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label guestLabel;
        private System.Windows.Forms.TextBox homeScoreTextbox;
        private System.Windows.Forms.TextBox guestScoreTextbox;
        private System.Windows.Forms.TextBox homePenaltyTextbox;
        private System.Windows.Forms.TextBox guestPenaltyTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button;
    }
}