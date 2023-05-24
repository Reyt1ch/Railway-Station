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
using System.Xml.Linq;

namespace RailwayStation
{
    public partial class Destinations : Form
    {
        DataService service;
        Destination toUpdate;
        public Destinations()
        {
            InitializeComponent();
            service = new DataService();
            toUpdate= new Destination();
            destinationsDataGridView.CellClick += DestinationsDataGridView_CellClick;
        }

        private void DestinationsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                addDestination.Hide();
                updateDestination.Show();
                nameTextBox.Text = destinationsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                toUpdate.id = service.FindDestinationByName(destinationsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).id;
            }

            if (e.ColumnIndex == 2)
            {
                service.DeleteDestination(service.FindDestinationByName(destinationsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).id);
                showDestinations();
            }
        }

        private void Destinations_Load(object sender, EventArgs e)
        {
            updateDestination.Hide();
            showDestinations();
        }

        private void showDestinations()
        {
            destinationsDataGridView.Columns.Clear();
            var data = (from d in service.GetAllDestinations()
                       select new
                       {
                           Destination = d.name
                       });
            destinationsDataGridView.DataSource = data.ToList();
            destinationsDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });
            destinationsDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void addDestination_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination()
            {
                name = nameTextBox.Text
            };
            try
            {
                service.AddDestination(destination);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showDestinations();
        }

        private void updateDestination_Click(object sender, EventArgs e)
        {
            toUpdate.name = nameTextBox.Text;

            try
            {
                service.UpdateDestination(toUpdate);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            addDestination.Show();
            updateDestination.Hide();
            nameTextBox.Text = "";
            showDestinations();
        }
    }
}
