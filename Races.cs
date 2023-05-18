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
    public partial class Races : Form
    {
        DataService service;
        Race toUpdate;
        public Races()
        {
            InitializeComponent();
            service = new DataService();
            toUpdate = new Race();
            racesDataGridView.CellClick += RacesDataGridView_CellClick;
        }

        private void RacesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                addRace.Hide();
                updateRace.Show();
                destinationTextBox.Text = racesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                class1SeatsTextBox.Text = racesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                class1PriceTextBox.Text = racesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                class2SeatsTextBox.Text = racesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                class2PriceTextBox.Text = racesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                class3SeatsTextBox.Text = racesDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                class3PriceTextBox.Text = racesDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

                toUpdate.id = Convert.ToInt32(racesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            if (e.ColumnIndex == 9)
            {
                service.DeleteRace(service.FindRaceById(Convert.ToInt32(racesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).id);
                showRaces();
            }
        }

        private void showRaces()
        {
            racesDataGridView.Columns.Clear();
            var data = (from r in service.GetAllRaces()
                        select new
                        {
                            ID = r.id,
                            Destination = r.Destination1.name,
                            r.numberOfSeatsClass1,
                            r.priceClass1,
                            r.numberOfSeatsClass2,
                            r.priceClass2,
                            r.numberOfSeatsClass3,
                            r.priceClass3
                        }).ToList();
            racesDataGridView.DataSource = data.ToList();
            racesDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });
            racesDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void Races_Load(object sender, EventArgs e)
        {
            updateRace.Hide();
            addRace.Show();
            showRaces();
        }

        private void addRace_Click(object sender, EventArgs e)
        {
            try
            {
                Race race = new Race()
                {
                    destination = service.FindDestinationByName(destinationTextBox.Text).id,
                    numberOfSeatsClass1 = Convert.ToInt32(class1SeatsTextBox.Text),
                    numberOfSeatsClass2 = Convert.ToInt32(class2SeatsTextBox.Text),
                    numberOfSeatsClass3 = Convert.ToInt32(class3SeatsTextBox.Text),
                    priceClass1 = Convert.ToInt32(class1PriceTextBox.Text),
                    priceClass2 = Convert.ToInt32(class2PriceTextBox.Text),
                    priceClass3 = Convert.ToInt32(class3PriceTextBox.Text)
                };
                service.AddRace(race);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showRaces();
        }

        private void updateRace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(destinationTextBox.Text))
            {
                MessageBox.Show("Destination cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(class1SeatsTextBox.Text))
            {
                MessageBox.Show("Number of seats for 1 class cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(class2SeatsTextBox.Text))
            {
                MessageBox.Show("Number of seats for 2 class cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(class3SeatsTextBox.Text))
            {
                MessageBox.Show("Number of seats for 3 class cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(class1PriceTextBox.Text))
            {
                MessageBox.Show("Price for 1 class cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(class2PriceTextBox.Text))
            {
                MessageBox.Show("Price for 1 class cannot be null or whitespace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(class2PriceTextBox.Text))
            {
                MessageBox.Show("Price for 1 class cannot be null or whitespace!");
                return;
            }

            toUpdate.destination = service.FindDestinationByName(destinationTextBox.Text).id;
            toUpdate.numberOfSeatsClass1 = Convert.ToInt32(class1SeatsTextBox.Text);
            toUpdate.numberOfSeatsClass2 = Convert.ToInt32(class2SeatsTextBox.Text);
            toUpdate.numberOfSeatsClass3 = Convert.ToInt32(class3SeatsTextBox.Text);
            toUpdate.priceClass1 = Convert.ToInt32(class1PriceTextBox.Text);
            toUpdate.priceClass2 = Convert.ToInt32(class2PriceTextBox.Text);
            toUpdate.priceClass3 = Convert.ToInt32(class3PriceTextBox.Text);

            try
            {
                service.UpdateRace(toUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            addRace.Show();
            updateRace.Hide();
            destinationTextBox.Text = "";
            class1SeatsTextBox.Text = "";
            class2SeatsTextBox.Text = "";
            class3SeatsTextBox.Text = "";
            class1PriceTextBox.Text = "";
            class2PriceTextBox.Text = "";
            class3PriceTextBox.Text = "";
            showRaces();
        }
    }
}
