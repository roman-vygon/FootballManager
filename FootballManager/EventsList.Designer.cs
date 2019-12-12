namespace FootballManager
{
    partial class EventsList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsList));
            this.eventList = new System.Windows.Forms.ListBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventList
            // 
            this.eventList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.eventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventList.FormattingEnabled = true;
            this.eventList.ItemHeight = 25;
            this.eventList.Location = new System.Drawing.Point(12, 12);
            this.eventList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(532, 407);
            this.eventList.TabIndex = 0;
            this.eventList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.EventList_DrawItem);
            this.eventList.SelectedIndexChanged += new System.EventHandler(this.EventList_SelectedIndexChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 440);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 13);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "score");
            this.imageList1.Images.SetKeyName(1, "save");
            this.imageList1.Images.SetKeyName(2, "tackle");
            this.imageList1.Images.SetKeyName(3, "shoot");
            this.imageList1.Images.SetKeyName(4, "pass");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EventsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.eventList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventsList";
            this.Text = "EventsList";
            this.Load += new System.EventHandler(this.EventsList_Load);
            this.Shown += new System.EventHandler(this.EventsList_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}