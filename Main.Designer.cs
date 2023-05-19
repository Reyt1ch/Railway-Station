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
            this.destinationsButton = new System.Windows.Forms.Button();
            this.racesButton = new System.Windows.Forms.Button();
            this.timetablesButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // destinationsButton
            // 
            this.destinationsButton.Location = new System.Drawing.Point(120, 74);
            this.destinationsButton.Name = "destinationsButton";
            this.destinationsButton.Size = new System.Drawing.Size(137, 53);
            this.destinationsButton.TabIndex = 0;
            this.destinationsButton.Text = "Destinations";
            this.destinationsButton.UseVisualStyleBackColor = true;
            this.destinationsButton.Click += new System.EventHandler(this.destinationsButton_Click);
            // 
            // racesButton
            // 
            this.racesButton.Location = new System.Drawing.Point(403, 74);
            this.racesButton.Name = "racesButton";
            this.racesButton.Size = new System.Drawing.Size(137, 53);
            this.racesButton.TabIndex = 1;
            this.racesButton.Text = "Races";
            this.racesButton.UseVisualStyleBackColor = true;
            this.racesButton.Click += new System.EventHandler(this.racesButton_Click);
            // 
            // timetablesButton
            // 
            this.timetablesButton.Location = new System.Drawing.Point(403, 213);
            this.timetablesButton.Name = "timetablesButton";
            this.timetablesButton.Size = new System.Drawing.Size(137, 53);
            this.timetablesButton.TabIndex = 2;
            this.timetablesButton.Text = "Timetables";
            this.timetablesButton.UseVisualStyleBackColor = true;
            this.timetablesButton.Click += new System.EventHandler(this.timetablesButton_Click);
            // 
            // reservationsButton
            // 
            this.reservationsButton.Location = new System.Drawing.Point(140, 213);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(137, 53);
            this.reservationsButton.TabIndex = 3;
            this.reservationsButton.Text = "Reservations";
            this.reservationsButton.UseVisualStyleBackColor = true;
            this.reservationsButton.Click += new System.EventHandler(this.reservationsButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.Location = new System.Drawing.Point(277, 310);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(137, 53);
            this.tasksButton.TabIndex = 4;
            this.tasksButton.Text = "Tasks";
            this.tasksButton.UseVisualStyleBackColor = true;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.timetablesButton);
            this.Controls.Add(this.racesButton);
            this.Controls.Add(this.destinationsButton);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button destinationsButton;
        private System.Windows.Forms.Button racesButton;
        private System.Windows.Forms.Button timetablesButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button tasksButton;
    }
}

