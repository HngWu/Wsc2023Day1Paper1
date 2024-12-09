using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsc2023Day1Paper1
{
    public partial class FrmDeleteRoster : Form
    {
        Wsc2023Day1Paper1DbContext context = new Wsc2023Day1Paper1DbContext();
        BindingSource flightsbs = new BindingSource();
        List<Flight> flights;

        public FrmDeleteRoster()
        {
            InitializeComponent(); this.WindowState = FormWindowState.Maximized;

            dgvflights.DefaultCellStyle.Font = new Font("Cambria", 16);

            monthpicker.Format = DateTimePickerFormat.Custom;
            monthpicker.CustomFormat = "MM";

            yearpicker.Format = DateTimePickerFormat.Custom;
            yearpicker.CustomFormat = "yyyy";
            tbnrosterflight.Enabled = false;

        }

        private void dgvflights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbnretrieve_Click(object sender, EventArgs e)
        {
            var month = monthpicker.Value.Month;
            var year = yearpicker.Value.Year;
            var isRosteringPerformed = context.DateRostereds
                .Where(x => x.date.Month == month && x.date.Year == year)
                .FirstOrDefault();
            if (isRosteringPerformed != null)
            {
                var flightRostered = context.FlightRosters
                    .Where(x => x.Flight.Date.Month == month && x.Flight.Date.Year == year)
                    .Select(x=> new
                    {
                        x.id,
                        x.flightId,
                        x.teamId,
                        x.Flight.Date,
                    })
                    .ToList();
                flightsbs.DataSource = flightRostered;
                dgvflights.DataSource = flightsbs;
                tbnrosterflight.Enabled = true;
                tbnretrieve.Enabled = false;
            }
            else
            {
                MessageBox.Show("Rostering for the selected period has not been performed. Please change the rostering period.");
                return;
            }
            
        }


        private void tbnrosterflight_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Confirm Deletion?", "Confirm", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.No)
            {
                return;
            }



            var rows = dgvflights.Rows;
            var month = monthpicker.Value.Month;
            var year = yearpicker.Value.Year;

            foreach (DataGridViewRow row in rows)
            {
                var flightRosterId = int.Parse(row.Cells["id"].Value.ToString());

                var flightRoster = context.FlightRosters.Where(x => x.id == flightRosterId).FirstOrDefault();
                context.FlightRosters.Remove(flightRoster);


                
                context.SaveChanges();




            }
            var rosterDate = context.DateRostereds.Where(x => x.date.Month == month && x.date.Year == year).FirstOrDefault();
            context.DateRostereds.Remove(rosterDate);
            context.SaveChanges();

            MessageBox.Show("Flight Rosters Deleted");
            FrmFlightRosterManagement frm = new FrmFlightRosterManagement();
            frm.Show();
            this.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            FrmDeleteRoster frm = new FrmDeleteRoster();
            frm.Show();
            this.Hide();
        }
    }
}
