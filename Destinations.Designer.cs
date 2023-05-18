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
            this.destinationsDataGridView.Location = new System.Drawing.Point(313, 12);
            this.destinationsDataGridView.Name = "destinationsDataGridView";
            this.destinationsDataGridView.RowHeadersWidth = 51;
            this.destinationsDataGridView.RowTemplate.Height = 24;
            this.destinationsDataGridView.Size = new System.Drawing.Size(475, 426);
            this.destinationsDataGridView.TabIndex = 0;
            // 
            // addDestination
            // 
            this.addDestination.Location = new System.Drawing.Point(132, 118);
            this.addDestination.Name = "addDestination";
            this.addDestination.Size = new System.Drawing.Size(150, 31);
            this.addDestination.TabIndex = 1;
            this.addDestination.Text = "Add Destination";
            this.addDestination.UseVisualStyleBackColor = true;
            this.addDestination.Click += new System.EventHandler(this.addDestination_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(30, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(252, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 71);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // updateDestination
            // 
            this.updateDestination.Location = new System.Drawing.Point(132, 118);
            this.updateDestination.Name = "updateDestination";
            this.updateDestination.Size = new System.Drawing.Size(150, 31);
            this.updateDestination.TabIndex = 4;
            this.updateDestination.Text = "Update Destination";
            this.updateDestination.UseVisualStyleBackColor = true;
            this.updateDestination.Click += new System.EventHandler(this.updateDestination_Click);
            // 
            // Destinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateDestination);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addDestination);
            this.Controls.Add(this.destinationsDataGridView);
            this.Name = "Destinations";
            this.Text = "Destinations";
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