using RailwayStation.Data;
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
    public partial class Reservations : Form
    {
        DataService service;
        Timetable toUpdate;
        public Reservations()
        {
            InitializeComponent();
            service = new DataService();
            toUpdate = new Timetable();
            reservationsDataGridView.CellClick += ReservationsDataGridView_CellClick;
        }

        private void ReservationsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                BuyTicket buyTicket = new BuyTicket(Convert.ToInt32(reservationsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                this.Hide();
                buyTicket.ShowDialog();
                buyTicket.Close();
                this.Show();
            }
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            destinationComboBox.Items.Clear();

            foreach (Destination destination in service.GetAllDestinations())
            {
                destinationComboBox.Items.Add(destination.name);
            }
            showTimetable(null);
        }

        private void showTimetable(string destination)
        {
            reservationsDataGridView.Columns.Clear();
            var timetable = (from t in service.GetAllTimetables()
                             select new
                             {
                                 ID = t.id,
                                 Destination = t.Race1.Destination1.name,
                                 DepartingDay = t.Day1.code,
                                 DepartingTime = t.departingTime,
                                 ArrivalDay = t.Day.code,
                                 ArrivalTime = t.arrivalTime
                             });

            if (destination != null)
            {
                    timetable = (from t in service.GetAllTimetables()
                                 where t.Race1.Destination1.name.Equals(destination)
                                 select new
                                 {
                                     ID = t.id,
                                     Destination = t.Race1.Destination1.name,
                                     DepartingDay = t.Day1.code,
                                     DepartingTime = t.departingTime,
                                     ArrivalDay = t.Day.code,
                                     ArrivalTime = t.arrivalTime
                                 });
            }
            reservationsDataGridView.DataSource = timetable.ToList();
            reservationsDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.buy,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Buy",
                Name = "buy"
            });
            reservationsDataGridView.Columns[0].Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(destinationComboBox.Text))
            {
                showTimetable(null);
                return;
            }
            showTimetable(destinationComboBox.Text);
        }
    }
}
