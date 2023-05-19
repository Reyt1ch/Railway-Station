using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayStation
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tasksDataSet.task7view' table. You can move, or remove it, as needed.
            this.task7viewTableAdapter.Fill(this.tasksDataSet.task7view);
            // TODO: This line of code loads data into the 'tasksDataSet.task6view' table. You can move, or remove it, as needed.
            this.task6viewTableAdapter.Fill(this.tasksDataSet.task6view);
            // TODO: This line of code loads data into the 'tasksDataSet.task5view' table. You can move, or remove it, as needed.
            this.task5viewTableAdapter.Fill(this.tasksDataSet.task5view);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.task5viewTableAdapter.Search(this.tasksDataSet.task5view, destinationToolStripTextBox.Text, minTimeToolStripTextBox.Text, maxTimeToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.task7viewTableAdapter.Task7(this.tasksDataSet.task7view, destinationToolStripTextBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void task8ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.task5viewTableAdapter.Task8(this.tasksDataSet.task5view, dayToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
