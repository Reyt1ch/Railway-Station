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
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Alexei") && textBox2.Text.Equals("123456"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Eroare! Nu a fost găsit utilizatorul");
            }
        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }
    }
}
