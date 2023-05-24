namespace RailwayStation
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.reservationsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationsDataGridView
            // 
            this.reservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsDataGridView.Location = new System.Drawing.Point(9, 63);
            this.reservationsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reservationsDataGridView.Name = "reservationsDataGridView";
            this.reservationsDataGridView.RowHeadersWidth = 51;
            this.reservationsDataGridView.RowTemplate.Height = 24;
            this.reservationsDataGridView.Size = new System.Drawing.Size(582, 292);
            this.reservationsDataGridView.TabIndex = 20;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchButton.Location = new System.Drawing.Point(350, 17);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 34);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Caută";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.destinationLabel.Location = new System.Drawing.Point(9, 26);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(130, 16);
            this.destinationLabel.TabIndex = 22;
            this.destinationLabel.Text = "Caută după destinație";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(145, 25);
            this.destinationComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(190, 21);
            this.destinationComboBox.TabIndex = 24;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reservationsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reservations";
            this.Text = "Reservări";
            this.Load += new System.EventHandler(this.Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView reservationsDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.ComboBox destinationComboBox;
    }
}