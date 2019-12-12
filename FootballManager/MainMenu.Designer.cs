namespace FootballManager
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.teamsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tournamentsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.податьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.податьЗаявкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamsList
            // 
            this.teamsList.BackColor = System.Drawing.SystemColors.Control;
            this.teamsList.FormattingEnabled = true;
            this.teamsList.Location = new System.Drawing.Point(11, 56);
            this.teamsList.Name = "teamsList";
            this.teamsList.Size = new System.Drawing.Size(197, 186);
            this.teamsList.TabIndex = 0;
            this.teamsList.SelectedIndexChanged += new System.EventHandler(this.TeamsList_SelectedIndexChanged);
            this.teamsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TeamsList_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Команды:";
            // 
            // tournamentsList
            // 
            this.tournamentsList.BackColor = System.Drawing.SystemColors.Control;
            this.tournamentsList.FormattingEnabled = true;
            this.tournamentsList.Location = new System.Drawing.Point(291, 56);
            this.tournamentsList.Name = "tournamentsList";
            this.tournamentsList.Size = new System.Drawing.Size(197, 186);
            this.tournamentsList.TabIndex = 2;
            this.tournamentsList.SelectedIndexChanged += new System.EventHandler(this.TournamentsList_SelectedIndexChanged);
            this.tournamentsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TournamentsList_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Турниры:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 260);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "timeLabel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.податьЗаявкуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // податьЗаявкуToolStripMenuItem
            // 
            this.податьЗаявкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрацияToolStripMenuItem,
            this.податьЗаявкуToolStripMenuItem1});
            this.податьЗаявкуToolStripMenuItem.Name = "податьЗаявкуToolStripMenuItem";
            this.податьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.податьЗаявкуToolStripMenuItem.Text = "Меню";
            // 
            // администрацияToolStripMenuItem
            // 
            this.администрацияToolStripMenuItem.Name = "администрацияToolStripMenuItem";
            this.администрацияToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.администрацияToolStripMenuItem.Text = "Администрация";
            this.администрацияToolStripMenuItem.Click += new System.EventHandler(this.АдминистрацияToolStripMenuItem_Click);
            // 
            // податьЗаявкуToolStripMenuItem1
            // 
            this.податьЗаявкуToolStripMenuItem1.Name = "податьЗаявкуToolStripMenuItem1";
            this.податьЗаявкуToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.податьЗаявкуToolStripMenuItem1.Text = "Подать заявку";
            this.податьЗаявкуToolStripMenuItem1.Click += new System.EventHandler(this.ПодатьЗаявкуToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать турнир";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 282);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tournamentsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamsList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox tournamentsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem податьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem податьЗаявкуToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

