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
            this.availableSeatsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.availableSeatsDataGridView.Name = "availableSeatsDataGridView";
            this.availableSeatsDataGridView.RowHeadersWidth = 51;
            this.availableSeatsDataGridView.RowTemplate.Height = 24;
            this.availableSeatsDataGridView.Size = new System.Drawing.Size(776, 131);
            this.availableSeatsDataGridView.TabIndex = 0;
            this.availableSeatsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableSeatsDataGridView_CellContentClick);
            // 
            // buy1Class
            // 
            this.buy1Class.Location = new System.Drawing.Point(30, 169);
            this.buy1Class.Name = "buy1Class";
            this.buy1Class.Size = new System.Drawing.Size(116, 41);
            this.buy1Class.TabIndex = 1;
            this.buy1Class.Text = "Buy 1 Class";
            this.buy1Class.UseVisualStyleBackColor = true;
            this.buy1Class.Click += new System.EventHandler(this.buy1Class_Click);
            // 
            // buy2Class
            // 
            this.buy2Class.Location = new System.Drawing.Point(228, 169);
            this.buy2Class.Name = "buy2Class";
            this.buy2Class.Size = new System.Drawing.Size(116, 41);
            this.buy2Class.TabIndex = 2;
            this.buy2Class.Text = "Buy 2 Class";
            this.buy2Class.UseVisualStyleBackColor = true;
            this.buy2Class.Click += new System.EventHandler(this.buy2Class_Click);
            // 
            // buy3Class
            // 
            this.buy3Class.Location = new System.Drawing.Point(434, 169);
            this.buy3Class.Name = "buy3Class";
            this.buy3Class.Size = new System.Drawing.Size(116, 41);
            this.buy3Class.TabIndex = 3;
            this.buy3Class.Text = "Buy 3 Class";
            this.buy3Class.UseVisualStyleBackColor = true;
            this.buy3Class.Click += new System.EventHandler(this.buy3Class_Click);
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Location = new System.Drawing.Point(12, 238);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.RowHeadersWidth = 51;
            this.ticketsDataGridView.RowTemplate.Height = 24;
            this.ticketsDataGridView.Size = new System.Drawing.Size(776, 186);
            this.ticketsDataGridView.TabIndex = 4;
            this.ticketsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsDataGridView_CellContentClick);
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketsDataGridView);
            this.Controls.Add(this.buy3Class);
            this.Controls.Add(this.buy2Class);
            this.Controls.Add(this.buy1Class);
            this.Controls.Add(this.availableSeatsDataGridView);
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