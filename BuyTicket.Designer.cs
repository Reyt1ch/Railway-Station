namespace RailwayStation
{
    partial class BuyTicket
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
            this.availableSeatsDataGridView = new System.Windows.Forms.DataGridView();
            this.buy1Class = new System.Windows.Forms.Button();
            this.buy2Class = new System.Windows.Forms.Button();
            this.buy3Class = new System.Windows.Forms.Button();
            this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.availableSeatsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // availableSeatsDataGridView
            // 
            this.availableSeatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableSeatsDataGridView.Location = new System.Drawing.Point(9, 10);
            this.availableSeatsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.availableSeatsDataGridView.Name = "availableSeatsDataGridView";
            this.availableSeatsDataGridView.RowHeadersWidth = 51;
            this.availableSeatsDataGridView.RowTemplate.Height = 24;
            this.availableSeatsDataGridView.Size = new System.Drawing.Size(582, 106);
            this.availableSeatsDataGridView.TabIndex = 0;
            this.availableSeatsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableSeatsDataGridView_CellContentClick);
            // 
            // buy1Class
            // 
            this.buy1Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buy1Class.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.buy1Class.Location = new System.Drawing.Point(22, 137);
            this.buy1Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buy1Class.Name = "buy1Class";
            this.buy1Class.Size = new System.Drawing.Size(87, 33);
            this.buy1Class.TabIndex = 1;
            this.buy1Class.Text = "Clasa 1";
            this.buy1Class.UseVisualStyleBackColor = false;
            this.buy1Class.Click += new System.EventHandler(this.buy1Class_Click);
            // 
            // buy2Class
            // 
            this.buy2Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buy2Class.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.buy2Class.Location = new System.Drawing.Point(171, 137);
            this.buy2Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buy2Class.Name = "buy2Class";
            this.buy2Class.Size = new System.Drawing.Size(87, 33);
            this.buy2Class.TabIndex = 2;
            this.buy2Class.Text = "Clasa 2";
            this.buy2Class.UseVisualStyleBackColor = false;
            this.buy2Class.Click += new System.EventHandler(this.buy2Class_Click);
            // 
            // buy3Class
            // 
            this.buy3Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buy3Class.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.buy3Class.Location = new System.Drawing.Point(326, 137);
            this.buy3Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buy3Class.Name = "buy3Class";
            this.buy3Class.Size = new System.Drawing.Size(87, 33);
            this.buy3Class.TabIndex = 3;
            this.buy3Class.Text = "Clasa 3";
            this.buy3Class.UseVisualStyleBackColor = false;
            this.buy3Class.Click += new System.EventHandler(this.buy3Class_Click);
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Location = new System.Drawing.Point(9, 193);
            this.ticketsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.RowHeadersWidth = 51;
            this.ticketsDataGridView.RowTemplate.Height = 24;
            this.ticketsDataGridView.Size = new System.Drawing.Size(582, 151);
            this.ticketsDataGridView.TabIndex = 4;
            this.ticketsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsDataGridView_CellContentClick);
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ticketsDataGridView);
            this.Controls.Add(this.buy3Class);
            this.Controls.Add(this.buy2Class);
            this.Controls.Add(this.buy1Class);
            this.Controls.Add(this.availableSeatsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableSeatsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView availableSeatsDataGridView;
        private System.Windows.Forms.Button buy1Class;
        private System.Windows.Forms.Button buy2Class;
        private System.Windows.Forms.Button buy3Class;
        private System.Windows.Forms.DataGridView ticketsDataGridView;
    }
}