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
using Day = RailwayStation.Data.Day;

namespace RailwayStation
{
    public partial class Timetables : Form
    {
        DataService service;
        Timetable toUpdate;

        public Timetables()
        {
            InitializeComponent();
            service = new DataService();
            toUpdate = new Timetable();
            timetablesDataGridView.CellClick += TimetablesDataGridView_CellClick;
        }

        private void TimetablesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                addTimetable.Hide();
                updateTimetable.Show();
                raceComboBox.Text = timetablesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                departingDayComboBox.Text = timetablesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                departingTimeTextBox.Text = timetablesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                arrivalDayComboBox.Text = timetablesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                arrivalTimeTextBox.Text = timetablesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                toUpdate.id = Convert.ToInt32(timetablesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            if (e.ColumnIndex == 7)
            {
                service.DeleteTimetable(Convert.ToInt32(timetablesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                showTimetables();
            }
        }

        private void Timetables_Load(object sender, EventArgs e)
        {
            updateTimetable.Hide();
            showTimetables();
            raceComboBox.Items.Clear();
            departingDayComboBox.Items.Clear();
            arrivalDayComboBox.Items.Clear();

            foreach (Race race in service.GetAllRaces())
            {
                raceComboBox.Items.Add(race.id);
            }

            foreach (Day day in service.GetAllDays())
            {
                arrivalDayComboBox.Items.Add(day.code);
                departingDayComboBox.Items.Add(day.code);
            }
        }

        private void showTimetables()
        {
            timetablesDataGridView.Columns.Clear();
            var data = (from t in service.GetAllTimetables()
                        select new
                        {
                            ID = t.id,
                            Race = t.race,
                            DepartingDay = t.Day1.code,
                            DepartingTime = t.departingTime,
                            ArrivalDay = t.Day.code,
                            ArrivalTime = t.arrivalTime
                        });
            timetablesDataGridView.DataSource = data.ToList();
            timetablesDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });
            timetablesDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = RailwayStation.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void addTimetable_Click(object sender, EventArgs e)
        {
            Timetable timetable = new Timetable()
            {
                race = Convert.ToInt32(raceComboBox.Text),
                departingDay = service.FindDayByCode(departingDayComboBox.Text).id,
                departingTime = TimeSpan.Parse(departingTimeTextBox.Text),
                arrivalDay = service.FindDayByCode(arrivalDayComboBox.Text).id,
                arrivalTime = TimeSpan.Parse(arrivalTimeTextBox.Text)
            };

            try
            {
                service.AddTimetable(timetable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            showTimetables();
        }

        private void updateTimetable_Click(object sender, EventArgs e)
        {
            toUpdate.race = Convert.ToInt32(raceComboBox.Text);
            toUpdate.departingDay = service.FindDayByCode(departingDayComboBox.Text).id;
            toUpdate.departingTime = TimeSpan.Parse(departingTimeTextBox.Text);
            toUpdate.arrivalDay = service.FindDayByCode(arrivalDayComboBox.Text).id;
            toUpdate.arrivalTime = TimeSpan.Parse(arrivalTimeTextBox.Text);

            try
            {
                service.UpdateTimetable(toUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            addTimetable.Show();
            updateTimetable.Hide();
            raceComboBox.Text = "";
            departingDayComboBox.Text = "";
            arrivalDayComboBox.Text = "";
            departingTimeTextBox.Text = "";
            arrivalTimeTextBox.Text = "";
            showTimetables();
        }
    }
}
