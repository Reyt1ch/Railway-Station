namespace RailwayStation
{
    partial class Timetables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timetables));
            this.updateTimetable = new System.Windows.Forms.Button();
            this.raceLabel = new System.Windows.Forms.Label();
            this.addTimetable = new System.Windows.Forms.Button();
            this.timetablesDataGridView = new System.Windows.Forms.DataGridView();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.departingDayComboBox = new System.Windows.Forms.ComboBox();
            this.departingDayLabel = new System.Windows.Forms.Label();
            this.departingTimeLabel = new System.Windows.Forms.Label();
            this.departingTimeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.arrivalDayLabel = new System.Windows.Forms.Label();
            this.arrivalDayComboBox = new System.Windows.Forms.ComboBox();
            this.cancelComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.enableComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimetable
            // 
            this.updateTimetable.Location = new System.Drawing.Point(123, 156);
            this.updateTimetable.Margin = new System.Windows.Forms.Padding(2);
            this.updateTimetable.Name = "updateTimetable";
            this.updateTimetable.Size = new System.Drawing.Size(86, 35);
            this.updateTimetable.TabIndex = 9;
            this.updateTimetable.Text = "Update Timetable";
            this.updateTimetable.UseVisualStyleBackColor = true;
            this.updateTimetable.Click += new System.EventHandler(this.updateTimetable_Click);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raceLabel.Location = new System.Drawing.Point(17, 10);
            this.raceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(45, 16);
            this.raceLabel.TabIndex = 8;
            this.raceLabel.Text = "Cursa:";
            // 
            // addTimetable
            // 
            this.addTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addTimetable.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.addTimetable.Location = new System.Drawing.Point(123, 156);
            this.addTimetable.Margin = new System.Windows.Forms.Padding(2);
            this.addTimetable.Name = "addTimetable";
            this.addTimetable.Size = new System.Drawing.Size(86, 35);
            this.addTimetable.TabIndex = 6;
            this.addTimetable.Text = "Adaugă";
            this.addTimetable.UseVisualStyleBackColor = false;
            this.addTimetable.Click += new System.EventHandler(this.addTimetable_Click);
            // 
            // timetablesDataGridView
            // 
            this.timetablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetablesDataGridView.Location = new System.Drawing.Point(230, 10);
            this.timetablesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.timetablesDataGridView.Name = "timetablesDataGridView";
            this.timetablesDataGridView.RowHeadersWidth = 51;
            this.timetablesDataGridView.RowTemplate.Height = 24;
            this.timetablesDataGridView.Size = new System.Drawing.Size(356, 346);
            this.timetablesDataGridView.TabIndex = 5;
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(20, 26);
            this.raceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(190, 21);
            this.raceComboBox.TabIndex = 10;
            // 
            // departingDayComboBox
            // 
            this.departingDayComboBox.FormattingEnabled = true;
            this.departingDayComboBox.Location = new System.Drawing.Point(20, 72);
            this.departingDayComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.departingDayComboBox.Name = "departingDayComboBox";
            this.departingDayComboBox.Size = new System.Drawing.Size(85, 21);
            this.departingDayComboBox.TabIndex = 11;
            // 
            // departingDayLabel
            // 
            this.departingDayLabel.AutoSize = true;
            this.departingDayLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.departingDayLabel.Location = new System.Drawing.Point(17, 56);
            this.departingDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departingDayLabel.Name = "departingDayLabel";
            this.departingDayLabel.Size = new System.Drawing.Size(62, 16);
            this.departingDayLabel.TabIndex = 12;
            this.departingDayLabel.Text = "Plecarea:";
            // 
            // departingTimeLabel
            // 
            this.departingTimeLabel.AutoSize = true;
            this.departingTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.departingTimeLabel.Location = new System.Drawing.Point(121, 56);
            this.departingTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departingTimeLabel.Name = "departingTimeLabel";
            this.departingTimeLabel.Size = new System.Drawing.Size(79, 16);
            this.departingTimeLabel.TabIndex = 14;
            this.departingTimeLabel.Text = "Ora Plecare:";
            // 
            // departingTimeTextBox
            // 
            this.departingTimeTextBox.Location = new System.Drawing.Point(123, 72);
            this.departingTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.departingTimeTextBox.Name = "departingTimeTextBox";
            this.departingTimeTextBox.Size = new System.Drawing.Size(86, 20);
            this.departingTimeTextBox.TabIndex = 15;
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(123, 118);
            this.arrivalTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(86, 20);
            this.arrivalTimeTextBox.TabIndex = 19;
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.arrivalTimeLabel.Location = new System.Drawing.Point(121, 102);
            this.arrivalTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(72, 16);
            this.arrivalTimeLabel.TabIndex = 18;
            this.arrivalTimeLabel.Text = "Ora Sosire:";
            // 
            // arrivalDayLabel
            // 
            this.arrivalDayLabel.AutoSize = true;
            this.arrivalDayLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.arrivalDayLabel.Location = new System.Drawing.Point(17, 102);
            this.arrivalDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arrivalDayLabel.Name = "arrivalDayLabel";
            this.arrivalDayLabel.Size = new System.Drawing.Size(55, 16);
            this.arrivalDayLabel.TabIndex = 17;
            this.arrivalDayLabel.Text = "Sosirea:";
            // 
            // arrivalDayComboBox
            // 
            this.arrivalDayComboBox.FormattingEnabled = true;
            this.arrivalDayComboBox.Location = new System.Drawing.Point(20, 118);
            this.arrivalDayComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.arrivalDayComboBox.Name = "arrivalDayComboBox";
            this.arrivalDayComboBox.Size = new System.Drawing.Size(85, 21);
            this.arrivalDayComboBox.TabIndex = 16;
            // 
            // cancelComboBox
            // 
            this.cancelComboBox.FormattingEnabled = true;
            this.cancelComboBox.Location = new System.Drawing.Point(20, 249);
            this.cancelComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.cancelComboBox.Name = "cancelComboBox";
            this.cancelComboBox.Size = new System.Drawing.Size(92, 21);
            this.cancelComboBox.TabIndex = 20;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(126, 249);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 28);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Anulare";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enableButton
            // 
            this.enableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enableButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.enableButton.Location = new System.Drawing.Point(126, 281);
            this.enableButton.Margin = new System.Windows.Forms.Padding(2);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(82, 29);
            this.enableButton.TabIndex = 23;
            this.enableButton.Text = "Restabilire";
            this.enableButton.UseVisualStyleBackColor = false;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // enableComboBox
            // 
            this.enableComboBox.FormattingEnabled = true;
            this.enableComboBox.Location = new System.Drawing.Point(20, 281);
            this.enableComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.enableComboBox.Name = "enableComboBox";
            this.enableComboBox.Size = new System.Drawing.Size(92, 21);
            this.enableComboBox.TabIndex = 22;
            // 
            // Timetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.enableComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.cancelComboBox);
            this.Controls.Add(this.arrivalTimeTextBox);
            this.Controls.Add(this.arrivalTimeLabel);
            this.Controls.Add(this.arrivalDayLabel);
            this.Controls.Add(this.arrivalDayComboBox);
            this.Controls.Add(this.departingTimeTextBox);
            this.Controls.Add(this.departingTimeLabel);
            this.Controls.Add(this.departingDayLabel);
            this.Controls.Add(this.departingDayComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.addTimetable);
            this.Controls.Add(this.timetablesDataGridView);
            this.Controls.Add(this.updateTimetable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Timetables";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Timetables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetablesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateTimetable;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Button addTimetable;
        private System.Windows.Forms.DataGridView timetablesDataGridView;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox departingDayComboBox;
        private System.Windows.Forms.Label departingDayLabel;
        private System.Windows.Forms.Label departingTimeLabel;
        private System.Windows.Forms.TextBox departingTimeTextBox;
        private System.Windows.Forms.TextBox arrivalTimeTextBox;
        private System.Windows.Forms.Label arrivalTimeLabel;
        private System.Windows.Forms.Label arrivalDayLabel;
        private System.Windows.Forms.ComboBox arrivalDayComboBox;
        private System.Windows.Forms.ComboBox cancelComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.ComboBox enableComboBox;
    }
}