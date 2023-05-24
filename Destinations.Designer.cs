namespace RailwayStation
{
    partial class Destinations
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
            this.destinationsDataGridView = new System.Windows.Forms.DataGridView();
            this.addDestination = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.updateDestination = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationsDataGridView
            // 
            this.destinationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destinationsDataGridView.Location = new System.Drawing.Point(235, 10);
            this.destinationsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destinationsDataGridView.Name = "destinationsDataGridView";
            this.destinationsDataGridView.RowHeadersWidth = 51;
            this.destinationsDataGridView.RowTemplate.Height = 24;
            this.destinationsDataGridView.Size = new System.Drawing.Size(356, 346);
            this.destinationsDataGridView.TabIndex = 0;
            // 
            // addDestination
            // 
            this.addDestination.Location = new System.Drawing.Point(99, 96);
            this.addDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDestination.Name = "addDestination";
            this.addDestination.Size = new System.Drawing.Size(112, 25);
            this.addDestination.TabIndex = 1;
            this.addDestination.Text = "Add Destination";
            this.addDestination.UseVisualStyleBackColor = true;
            this.addDestination.Click += new System.EventHandler(this.addDestination_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(22, 73);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(190, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(19, 55);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Denumirea:";
            // 
            // updateDestination
            // 
            this.updateDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateDestination.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateDestination.Location = new System.Drawing.Point(99, 96);
            this.updateDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateDestination.Name = "updateDestination";
            this.updateDestination.Size = new System.Drawing.Size(113, 34);
            this.updateDestination.TabIndex = 4;
            this.updateDestination.Text = "Actualizează";
            this.updateDestination.UseVisualStyleBackColor = false;
            this.updateDestination.Click += new System.EventHandler(this.updateDestination_Click);
            // 
            // Destinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.updateDestination);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addDestination);
            this.Controls.Add(this.destinationsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Destinations";
            this.Text = "Destinații";
            this.Load += new System.EventHandler(this.Destinations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView destinationsDataGridView;
        private System.Windows.Forms.Button addDestination;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button updateDestination;
    }
}