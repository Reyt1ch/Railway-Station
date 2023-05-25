namespace RailwayStation
{
    partial class Tasks
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.task5viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksDataSet = new RailwayStation.TasksDataSet();
            this.task6viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task7viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.destinationToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.destinationToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.minTimeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.minTimeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.maxTimeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maxTimeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.task7ToolStrip = new System.Windows.Forms.ToolStrip();
            this.destinationToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.destinationToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.task7ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.task8ToolStrip = new System.Windows.Forms.ToolStrip();
            this.dayToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dayToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.task8ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.task5viewTableAdapter = new RailwayStation.TasksDataSetTableAdapters.task5viewTableAdapter();
            this.task6viewTableAdapter = new RailwayStation.TasksDataSetTableAdapters.task6viewTableAdapter();
            this.task7viewTableAdapter = new RailwayStation.TasksDataSetTableAdapters.task7viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.task5viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task6viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task7viewBindingSource)).BeginInit();
            this.searchToolStrip.SuspendLayout();
            this.task7ToolStrip.SuspendLayout();
            this.task8ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // task5viewBindingSource
            // 
            this.task5viewBindingSource.DataMember = "task5view";
            this.task5viewBindingSource.DataSource = this.tasksDataSet;
            // 
            // tasksDataSet
            // 
            this.tasksDataSet.DataSetName = "TasksDataSet";
            this.tasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // task6viewBindingSource
            // 
            this.task6viewBindingSource.DataMember = "task6view";
            this.task6viewBindingSource.DataSource = this.tasksDataSet;
            // 
            // task7viewBindingSource
            // 
            this.task7viewBindingSource.DataMember = "task7view";
            this.task7viewBindingSource.DataSource = this.tasksDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Task5";
            reportDataSource1.Value = this.task5viewBindingSource;
            reportDataSource2.Name = "Task6";
            reportDataSource2.Value = this.task6viewBindingSource;
            reportDataSource3.Name = "Task7";
            reportDataSource3.Value = this.task7viewBindingSource;
            reportDataSource4.Name = "Task8";
            reportDataSource4.Value = this.task5viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RailwayStation.Report.Tasks.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 78);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(637, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destinationToolStripLabel,
            this.destinationToolStripTextBox,
            this.minTimeToolStripLabel,
            this.minTimeToolStripTextBox,
            this.maxTimeToolStripLabel,
            this.maxTimeToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(662, 25);
            this.searchToolStrip.TabIndex = 1;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // destinationToolStripLabel
            // 
            this.destinationToolStripLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.destinationToolStripLabel.Name = "destinationToolStripLabel";
            this.destinationToolStripLabel.Size = new System.Drawing.Size(68, 22);
            this.destinationToolStripLabel.Text = "Destinația:";
            // 
            // destinationToolStripTextBox
            // 
            this.destinationToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destinationToolStripTextBox.Name = "destinationToolStripTextBox";
            this.destinationToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // minTimeToolStripLabel
            // 
            this.minTimeToolStripLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.minTimeToolStripLabel.Name = "minTimeToolStripLabel";
            this.minTimeToolStripLabel.Size = new System.Drawing.Size(51, 22);
            this.minTimeToolStripLabel.Text = "MinOră:";
            // 
            // minTimeToolStripTextBox
            // 
            this.minTimeToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minTimeToolStripTextBox.Name = "minTimeToolStripTextBox";
            this.minTimeToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // maxTimeToolStripLabel
            // 
            this.maxTimeToolStripLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.maxTimeToolStripLabel.Name = "maxTimeToolStripLabel";
            this.maxTimeToolStripLabel.Size = new System.Drawing.Size(55, 22);
            this.maxTimeToolStripLabel.Text = "MaxOră:";
            // 
            // maxTimeToolStripTextBox
            // 
            this.maxTimeToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maxTimeToolStripTextBox.Name = "maxTimeToolStripTextBox";
            this.maxTimeToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.searchToolStripButton.Text = "Caută";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // task7ToolStrip
            // 
            this.task7ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.task7ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destinationToolStripLabel1,
            this.destinationToolStripTextBox1,
            this.task7ToolStripButton});
            this.task7ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.task7ToolStrip.Name = "task7ToolStrip";
            this.task7ToolStrip.Size = new System.Drawing.Size(662, 25);
            this.task7ToolStrip.TabIndex = 2;
            this.task7ToolStrip.Text = "task7ToolStrip";
            // 
            // destinationToolStripLabel1
            // 
            this.destinationToolStripLabel1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.destinationToolStripLabel1.Name = "destinationToolStripLabel1";
            this.destinationToolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.destinationToolStripLabel1.Text = "Destinația:";
            // 
            // destinationToolStripTextBox1
            // 
            this.destinationToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.destinationToolStripTextBox1.Name = "destinationToolStripTextBox1";
            this.destinationToolStripTextBox1.Size = new System.Drawing.Size(76, 25);
            // 
            // task7ToolStripButton
            // 
            this.task7ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.task7ToolStripButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.task7ToolStripButton.Name = "task7ToolStripButton";
            this.task7ToolStripButton.Size = new System.Drawing.Size(65, 22);
            this.task7ToolStripButton.Text = "Sarcina 7";
            this.task7ToolStripButton.Click += new System.EventHandler(this.task7ToolStripButton_Click);
            // 
            // task8ToolStrip
            // 
            this.task8ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.task8ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripLabel,
            this.dayToolStripTextBox,
            this.task8ToolStripButton});
            this.task8ToolStrip.Location = new System.Drawing.Point(0, 50);
            this.task8ToolStrip.Name = "task8ToolStrip";
            this.task8ToolStrip.Size = new System.Drawing.Size(662, 25);
            this.task8ToolStrip.TabIndex = 3;
            this.task8ToolStrip.Text = "task8ToolStrip";
            // 
            // dayToolStripLabel
            // 
            this.dayToolStripLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.dayToolStripLabel.Name = "dayToolStripLabel";
            this.dayToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.dayToolStripLabel.Text = "Ziua:";
            // 
            // dayToolStripTextBox
            // 
            this.dayToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dayToolStripTextBox.Name = "dayToolStripTextBox";
            this.dayToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // task8ToolStripButton
            // 
            this.task8ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.task8ToolStripButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.task8ToolStripButton.Name = "task8ToolStripButton";
            this.task8ToolStripButton.Size = new System.Drawing.Size(65, 22);
            this.task8ToolStripButton.Text = "Sarcina 8";
            this.task8ToolStripButton.Click += new System.EventHandler(this.task8ToolStripButton_Click);
            // 
            // task5viewTableAdapter
            // 
            this.task5viewTableAdapter.ClearBeforeFill = true;
            // 
            // task6viewTableAdapter
            // 
            this.task6viewTableAdapter.ClearBeforeFill = true;
            // 
            // task7viewTableAdapter
            // 
            this.task7viewTableAdapter.ClearBeforeFill = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 410);
            this.Controls.Add(this.task8ToolStrip);
            this.Controls.Add(this.task7ToolStrip);
            this.Controls.Add(this.searchToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tasks";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.task5viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task6viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task7viewBindingSource)).EndInit();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.task7ToolStrip.ResumeLayout(false);
            this.task7ToolStrip.PerformLayout();
            this.task8ToolStrip.ResumeLayout(false);
            this.task8ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TasksDataSet tasksDataSet;
        private System.Windows.Forms.BindingSource task5viewBindingSource;
        private TasksDataSetTableAdapters.task5viewTableAdapter task5viewTableAdapter;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel destinationToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox destinationToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel minTimeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox minTimeToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel maxTimeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maxTimeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.BindingSource task6viewBindingSource;
        private TasksDataSetTableAdapters.task6viewTableAdapter task6viewTableAdapter;
        private System.Windows.Forms.BindingSource task7viewBindingSource;
        private TasksDataSetTableAdapters.task7viewTableAdapter task7viewTableAdapter;
        private System.Windows.Forms.ToolStrip task7ToolStrip;
        private System.Windows.Forms.ToolStripLabel destinationToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox destinationToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton task7ToolStripButton;
        private System.Windows.Forms.ToolStrip task8ToolStrip;
        private System.Windows.Forms.ToolStripLabel dayToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dayToolStripTextBox;
        private System.Windows.Forms.ToolStripButton task8ToolStripButton;
    }
}