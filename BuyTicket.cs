using Microsoft.VisualBasic;
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
    public partial class BuyTicket : Form
    {
        int timetableID;
        DataService service;
        public BuyTicket(int timetableID)
        {
            InitializeComponent();
            this.timetableID = timetableID;
            service = new DataService();
            ticketsDataGridView.CellClick += TicketsDataGridView_CellClick;
        }

        private void TicketsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                try
                {
                    service.DeleteReservation((int)ticketsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            showTickets();
            showAvailableSeats();
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            showAvailableSeats();
            showTickets();
        }

        private void showAvailableSeats()
        {
            availableSeatsDataGridView.Columns.Clear();
            var availableSeats = (from t in service.GetAllTimetables()
                                  where t.id == this.timetableID
                                  select new
                                  {
                                      NumberOfSeatsClass1 = t.Race1.numberOfSeatsClass1 - service.GetAllReservations().Where(x => x.Class1.className.Equals("1 Class") && x.timetable == this.timetableID).Count(),
                                      PriceClass1 = t.Race1.priceClass1,
                                      NumberOfSeatsClass2 = t.Race1.numberOfSeatsClass2 - service.GetAllReservations().Where(x => x.Class1.className.Equals("2 Class") && x.timetable == this.timetableID).Count(),
                                      PriceClass2 = t.Race1.priceClass2,
                                      NumberOfSeatsClass3 = t.Race1.numberOfSeatsClass3 - service.GetAllReservations().Where(x => x.Class1.className.Equals("3 Class") && x.timetable == this.timetableID).Count(),
                                      PriceClass3 = t.Race1.priceClass3,
                                  });

            availableSeatsDataGridView.DataSource = availableSeats.ToList();
        }

        private void showTickets()
        {
            ticketsDataGridView.Columns.Clear();
            var tickets = (from r in service.GetAllReservations()
                           select new
                           {
                               ID = r.id,
                               Destination = r.Timetable1.Race1.Destination1.name,
                               Departing = r.Timetable1.Day1.code + " " + r.Timetable1.departingTime,
                               Arrival = r.Timetable1.Day.code + " " + r.Timetable1.arrivalTime,
                               ClassType = r.Class1.className
                           });
            ticketsDataGridView.DataSource = tickets.ToList();
            ticketsDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void availableSeatsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buy1Class_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(availableSeatsDataGridView.Rows[0].Cells[0].Value.ToString()) == 0)
            {
                MessageBox.Show("Not enough seats!");
                return;
            }

            Reservation reservation = new Reservation()
            {
                timetable = this.timetableID,
                @class = 1,
                numberOfSeats = 1
            };

            try
            {
                service.AddReservation(reservation);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAvailableSeats();
        }

        private void buy2Class_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(availableSeatsDataGridView.Rows[0].Cells[2].Value.ToString()) == 0)
            {
                MessageBox.Show("Not enough seats!");
                return;
            }

            Reservation reservation = new Reservation()
            {
                timetable = this.timetableID,
                @class = 2,
                numberOfSeats = 1
            };

            try
            {
                service.AddReservation(reservation);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAvailableSeats();
        }

        private void buy3Class_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(availableSeatsDataGridView.Rows[0].Cells[4].Value.ToString()) == 0)
            {
                MessageBox.Show("Not enough seats!");
                return;
            }

            Reservation reservation = new Reservation()
            {
                timetable = this.timetableID,
                @class = 3,
                numberOfSeats = 1
            };

            try
            {
                service.AddReservation(reservation);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAvailableSeats();
        }

        private void ticketsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
