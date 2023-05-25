namespace RailwayStation
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.destinationsButton = new System.Windows.Forms.Button();
            this.racesButton = new System.Windows.Forms.Button();
            this.timetablesButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationsButton
            // 
            this.destinationsButton.BackColor = System.Drawing.Color.Gray;
            this.destinationsButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.destinationsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.destinationsButton.Location = new System.Drawing.Point(442, 314);
            this.destinationsButton.Margin = new System.Windows.Forms.Padding(2);
            this.destinationsButton.Name = "destinationsButton";
            this.destinationsButton.Size = new System.Drawing.Size(103, 43);
            this.destinationsButton.TabIndex = 0;
            this.destinationsButton.Text = "Destinații";
            this.destinationsButton.UseVisualStyleBackColor = false;
            this.destinationsButton.Click += new System.EventHandler(this.destinationsButton_Click);
            // 
            // racesButton
            // 
            this.racesButton.BackColor = System.Drawing.Color.Gray;
            this.racesButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.racesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.racesButton.Location = new System.Drawing.Point(561, 314);
            this.racesButton.Margin = new System.Windows.Forms.Padding(2);
            this.racesButton.Name = "racesButton";
            this.racesButton.Size = new System.Drawing.Size(103, 43);
            this.racesButton.TabIndex = 1;
            this.racesButton.Text = "Curse";
            this.racesButton.UseVisualStyleBackColor = false;
            this.racesButton.Click += new System.EventHandler(this.racesButton_Click);
            // 
            // timetablesButton
            // 
            this.timetablesButton.BackColor = System.Drawing.Color.Gray;
            this.timetablesButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.timetablesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timetablesButton.Location = new System.Drawing.Point(442, 11);
            this.timetablesButton.Margin = new System.Windows.Forms.Padding(2);
            this.timetablesButton.Name = "timetablesButton";
            this.timetablesButton.Size = new System.Drawing.Size(103, 43);
            this.timetablesButton.TabIndex = 2;
            this.timetablesButton.Text = "Orar";
            this.timetablesButton.UseVisualStyleBackColor = false;
            this.timetablesButton.Click += new System.EventHandler(this.timetablesButton_Click);
            // 
            // reservationsButton
            // 
            this.reservationsButton.BackColor = System.Drawing.Color.Gray;
            this.reservationsButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.reservationsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationsButton.Location = new System.Drawing.Point(317, 11);
            this.reservationsButton.Margin = new System.Windows.Forms.Padding(2);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(103, 43);
            this.reservationsButton.TabIndex = 3;
            this.reservationsButton.Text = "Reservări";
            this.reservationsButton.UseVisualStyleBackColor = false;
            this.reservationsButton.Click += new System.EventHandler(this.reservationsButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.BackColor = System.Drawing.Color.Gray;
            this.tasksButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasksButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tasksButton.Location = new System.Drawing.Point(561, 11);
            this.tasksButton.Margin = new System.Windows.Forms.Padding(2);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(103, 43);
            this.tasksButton.TabIndex = 4;
            this.tasksButton.Text = "Raport";
            this.tasksButton.UseVisualStyleBackColor = false;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.timetablesButton);
            this.Controls.Add(this.racesButton);
            this.Controls.Add(this.destinationsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = " Pagina Principală";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button destinationsButton;
        private System.Windows.Forms.Button racesButton;
        private System.Windows.Forms.Button timetablesButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

