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
            ((System.ComponentModel.ISupportInitialize)(this.timetablesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimetable
            // 
            this.updateTimetable.Location = new System.Drawing.Point(166, 293);
            this.updateTimetable.Name = "updateTimetable";
            this.updateTimetable.Size = new System.Drawing.Size(114, 43);
            this.updateTimetable.TabIndex = 9;
            this.updateTimetable.Text = "Update Timetable";
            this.updateTimetable.UseVisualStyleBackColor = true;
            this.updateTimetable.Click += new System.EventHandler(this.updateTimetable_Click);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(25, 113);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(43, 16);
            this.raceLabel.TabIndex = 8;
            this.raceLabel.Text = "Race:";
            // 
            // addTimetable
            // 
            this.addTimetable.Location = new System.Drawing.Point(166, 293);
            this.addTimetable.Name = "addTimetable";
            this.addTimetable.Size = new System.Drawing.Size(114, 43);
            this.addTimetable.TabIndex = 6;
            this.addTimetable.Text = "Add Timetable";
            this.addTimetable.UseVisualStyleBackColor = true;
            this.addTimetable.Click += new System.EventHandler(this.addTimetable_Click);
            // 
            // timetablesDataGridView
            // 
            this.timetablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetablesDataGridView.Location = new System.Drawing.Point(306, 12);
            this.timetablesDataGridView.Name = "timetablesDataGridView";
            this.timetablesDataGridView.RowHeadersWidth = 51;
            this.timetablesDataGridView.RowTemplate.Height = 24;
            this.timetablesDataGridView.Size = new System.Drawing.Size(475, 426);
            this.timetablesDataGridView.TabIndex = 5;
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(28, 133);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(252, 24);
            this.raceComboBox.TabIndex = 10;
            // 
            // departingDayComboBox
            // 
            this.departingDayComboBox.FormattingEnabled = true;
            this.departingDayComboBox.Location = new System.Drawing.Point(28, 189);
            this.departingDayComboBox.Name = "departingDayComboBox";
            this.departingDayComboBox.Size = new System.Drawing.Size(112, 24);
            this.departingDayComboBox.TabIndex = 11;
            // 
            // departingDayLabel
            // 
            this.departingDayLabel.AutoSize = true;
            this.departingDayLabel.Location = new System.Drawing.Point(25, 170);
            this.departingDayLabel.Name = "departingDayLabel";
            this.departingDayLabel.Size = new System.Drawing.Size(97, 16);
            this.departingDayLabel.TabIndex = 12;
            this.departingDayLabel.Text = "Departing Day:";
            // 
            // departingTimeLabel
            // 
            this.departingTimeLabel.AutoSize = true;
            this.departingTimeLabel.Location = new System.Drawing.Point(163, 170);
            this.departingTimeLabel.Name = "departingTimeLabel";
            this.departingTimeLabel.Size = new System.Drawing.Size(103, 16);
            this.departingTimeLabel.TabIndex = 14;
            this.departingTimeLabel.Text = "Departing Time:";
            // 
            // departingTimeTextBox
            // 
            this.departingTimeTextBox.Location = new System.Drawing.Point(166, 189);
            this.departingTimeTextBox.Name = "departingTimeTextBox";
            this.departingTimeTextBox.Size = new System.Drawing.Size(114, 22);
            this.departingTimeTextBox.TabIndex = 15;
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(166, 246);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(114, 22);
            this.arrivalTimeTextBox.TabIndex = 19;
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Location = new System.Drawing.Point(163, 227);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(82, 16);
            this.arrivalTimeLabel.TabIndex = 18;
            this.arrivalTimeLabel.Text = "Arrival Time:";
            // 
            // arrivalDayLabel
            // 
            this.arrivalDayLabel.AutoSize = true;
            this.arrivalDayLabel.Location = new System.Drawing.Point(25, 227);
            this.arrivalDayLabel.Name = "arrivalDayLabel";
            this.arrivalDayLabel.Size = new System.Drawing.Size(76, 16);
            this.arrivalDayLabel.TabIndex = 17;
            this.arrivalDayLabel.Text = "Arrival Day:";
            // 
            // arrivalDayComboBox
            // 
            this.arrivalDayComboBox.FormattingEnabled = true;
            this.arrivalDayComboBox.Location = new System.Drawing.Point(28, 246);
            this.arrivalDayComboBox.Name = "arrivalDayComboBox";
            this.arrivalDayComboBox.Size = new System.Drawing.Size(112, 24);
            this.arrivalDayComboBox.TabIndex = 16;
            // 
            // Timetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Timetables";
            this.Text = "Timetables";
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
    }
}