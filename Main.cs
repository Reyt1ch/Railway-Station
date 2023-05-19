using RailwayStation.Service;
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
    public partial class Main : Form
    {
        Destinations destinations;
        Races races;
        Timetables timetables;
        Reservations reservations;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            destinations = new Destinations();
            races = new Races();
            timetables = new Timetables();
            reservations = new Reservations();
        }

        private void destinationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            destinations.ShowDialog();
            this.Show();
        }

        private void racesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            races.ShowDialog();
            this.Show();
        }

        private void timetablesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            timetables.ShowDialog();
            this.Show();
        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservations.ShowDialog();
            this.Show();
        }
    }
}
