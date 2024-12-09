using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsc2023Day1Paper1
{
    public partial class FrmFlightRosterManagement : Form
    {
        Wsc2023Day1Paper1DbContext context = new Wsc2023Day1Paper1DbContext();
        BindingSource flightsbs = new BindingSource();
        List<Flight> flights;
        List<trackTeams> trackingList;

        BindingSource flightsrecordsunabletoregisterbs = new BindingSource();
        BindingSource teamsunabletoreturntohomeairportbs = new BindingSource();
        BindingSource flightrecordsviolatedRestPeriodbs = new BindingSource();
        BindingSource teamtotalactivedutyhoursbs = new BindingSource();
        List<Team> teamList = new List<Team>();


        public FrmFlightRosterManagement()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            monthpicker.Format = DateTimePickerFormat.Custom;
            monthpicker.CustomFormat = "MM";
            
            yearpicker.Format = DateTimePickerFormat.Custom;
            yearpicker.CustomFormat = "yyyy";
            dgvflights.DefaultCellStyle.Font = new Font("Cambria", 16);
            dgvflightrecordsrestperiod.DefaultCellStyle.Font = new Font("Cambria", 16);
            dgvteamsunabletoreturntoairport.DefaultCellStyle.Font = new Font("Cambria", 16);
            dgvtotalactivehours.DefaultCellStyle.Font = new Font("Cambria", 16);
            dgvflightsunabletoroster.DefaultCellStyle.Font = new Font("Cambria", 16);

            btnnrosterflight.Enabled = false;
            tbnsave.Enabled = false;

        }

        public void loadFlights()
        {
            var month = monthpicker.Value.Month;
            var year = yearpicker.Value.Year;
            flights = context.Flights
                .Where(x => x.Date.Month == month && x.Date.Year == year)
                .OrderBy(x => x.Date)
                .ThenBy(x => x.Time)
                .ThenBy(x => x.Start)
                .ThenBy(x => x.Dest)
                .ThenBy(x => x.flightId)
                .ToList();
            if (flights.Count == 0)
            {
                MessageBox.Show("No flights to roster");
                return;
            }
            var datatable = new DataTable();
            datatable.Columns.Add("Flight Number");
            datatable.Columns.Add("Date");
            datatable.Columns.Add("Time");
            datatable.Columns.Add("Departure");
            datatable.Columns.Add("Destination");
            datatable.Columns.Add("Minimum Size");
            datatable.Columns.Add("Maximum Size");
            datatable.Columns.Add("Team Number");

            foreach (var flight in flights)
            {
                var row = datatable.NewRow();
                row["Flight Number"] = flight.flightId;
                row["Date"] = flight.Date.Date;
                row["Time"] = flight.Time;
                row["Departure"] = flight.Start;
                row["Destination"] = flight.Dest;
                row["Minimum Size"] = flight.Min_Team_Size;
                row["Maximum Size"] = flight.Max_Team_Size;
                datatable.Rows.Add(row);
            }

            flightsbs.DataSource = datatable;
            dgvflights.DataSource = flightsbs;
        }

        private void FrmFlightRosterManagement_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbnretrieve_Click(object sender, EventArgs e)
        {
            if(tbnretrieve.Enabled == false)
            {
                MessageBox.Show("Please Press the Clear Button to clear the input fields");
                return;
            }


            var month = monthpicker.Value.Month;
            var year = yearpicker.Value.Year;
            var isRosteringPerformed = context.DateRostereds
                .Where(x => x.date.Month == month && x.date.Year == year)
                .FirstOrDefault();
            if (isRosteringPerformed != null)
            {
                MessageBox.Show("Rostering for the selected period has already been performed. Please change the rostering period.");
                return;
            }
            flights = context.Flights
                .Where(x => x.Date.Month == month && x.Date.Year == year)
                .OrderBy(x => x.Date)
                .ThenBy(x => x.Time)
                .ThenBy(x => x.Start)
                .ThenBy(x => x.Dest)
                .ThenBy(x => x.flightId)
                .ToList();
            if (flights.Count == 0)
            {
                MessageBox.Show("No flights to roster");
                return;
            }
            var datatable = new DataTable();
            datatable.Columns.Add("Flight Number");
            datatable.Columns.Add("Date");
            datatable.Columns.Add("Time");
            datatable.Columns.Add("Departure");
            datatable.Columns.Add("Destination");
            datatable.Columns.Add("Minimum Size");
            datatable.Columns.Add("Maximum Size");
            datatable.Columns.Add("Team Number");

            foreach (var flight in flights)
            {
                var row = datatable.NewRow();
                row["Flight Number"] = flight.flightId;
                row["Date"] = flight.Date.Date;
                row["Time"] = flight.Time;
                row["Departure"] = flight.Start;
                row["Destination"] = flight.Dest;
                row["Minimum Size"] = flight.Min_Team_Size;
                row["Maximum Size"] = flight.Max_Team_Size;
                datatable.Rows.Add(row);
            }

            flightsbs.DataSource = datatable;
            dgvflights.DataSource = flightsbs;
            btnnrosterflight.Enabled = true;
        }
        private void DetachedEntities(List<Team> entities)
        {
            foreach (var entity in entities)
            {
                context.Entry(entity).State = EntityState.Detached;
            }
        }

        public void CreateMonthlyFlightRosters(int year, int month)
        {
            if (IsRosteringPerformed(year, month))
            {
                MessageBox.Show("Rostering for the selected period has already been performed. Please change the rostering period.");
                return;
            }

            
            
        }

        private bool IsRosteringPerformed(int year, int month)
        {
            // Implement logic to check if rostering has already been performed for the selected period
            return false;
        }


        public class trackTeams
        {
            public int teamId { get; set; }
            public string iata { get; set; }
            public DateTime arrivalTime { get; set; }
        }

        private void tbnrosterflight_Click(object sender, EventArgs e)
        {
            var month = monthpicker.Value.Month;
            var year = yearpicker.Value.Year;
            flights = context.Flights
                .Where(x => x.Date.Month == month && x.Date.Year == year)
                .OrderBy(x => x.Date)
                .ThenBy(x => x.Time)
                .ThenBy(x => x.Start)
                .ThenBy(x => x.Dest)
                .ThenBy(x => x.flightId)
                .ToList();

            

            var datatable = new DataTable();
            datatable.Columns.Add("Flight Number");
            datatable.Columns.Add("Date");
            datatable.Columns.Add("Time");
            datatable.Columns.Add("Departure");
            datatable.Columns.Add("Destination");
            datatable.Columns.Add("Minimum Size");
            datatable.Columns.Add("Maximum Size");
            datatable.Columns.Add("Team Number");

            teamList = context.Teams.ToList(); // Create a copy of the teamList

            var teamTrackingList = new List<trackTeams>();

            foreach (var team in teamList)
            {
                var trackTeam = new trackTeams
                {
                    teamId = team.TeamId,
                    iata = team.iata,
                    arrivalTime = new DateTime(year, month, 1, 0, 0, 0)
                };
                teamTrackingList.Add(trackTeam);
            }


            foreach (var flight in flights)
            {
                var availableTeams = teamList.Where(t => t.TeamAssigneds.Count() >= flight.Min_Team_Size &&
                                                    t.TeamAssigneds.Count() <= flight.Max_Team_Size &&
                                                    t.iata == flight.Start)
                                                    .ToList();

                var flightStartTime = flight.Date + flight.Time;
                var flightArrivalTime = flight.Date + flight.Time + TimeSpan.FromMinutes(flight.Duration_minutes);

                var assignedTeam = availableTeams
                    .Where(x => teamTrackingList.Where(y => y.teamId == x.TeamId).FirstOrDefault().arrivalTime <= flightStartTime)
                    .OrderBy(t => t.TeamAssigneds.Count()).ThenBy(t => t.TeamId).FirstOrDefault();

                var row = datatable.NewRow();
                row["Flight Number"] = flight.flightId;
                row["Date"] = flight.Date.Date;
                row["Time"] = flight.Time;
                row["Departure"] = flight.Start;
                row["Destination"] = flight.Dest;
                row["Minimum Size"] = flight.Min_Team_Size;
                row["Maximum Size"] = flight.Max_Team_Size;

                if (assignedTeam != null)
                {
                    row["Team Number"] = assignedTeam.TeamId;
                    teamList.Where(x => x.TeamId == assignedTeam.TeamId).FirstOrDefault().iata = flight.Dest;
                    teamTrackingList.Where(x => x.teamId == assignedTeam.TeamId).FirstOrDefault().arrivalTime = flightArrivalTime;
                }

                datatable.Rows.Add(row);
            }

            flightsbs.DataSource = datatable;
            dgvflights.DataSource = flightsbs;

            trackingList = teamTrackingList;
            tbnsave.Enabled = true;
            btnnrosterflight.Enabled = false;




            tbnretrieve.Enabled = false;



        }





        private void tbnsave_Click(object sender, EventArgs e)
        {
            DetachedEntities(teamList);


            var rows = dgvflights.Rows;
            try
            {
                var flightrecordsunabletoroster = new List<Flight>();
                var teamsunabletoreturntohomeairport = new List<Team>();
                var flightrecordsviolatedRestPeriod = new List<Flight>();
                var teamtotalactivedutyhours = new Dictionary<int, double>();

                teamtotalactivedutyhours = context.Teams.ToDictionary(x => x.TeamId, x => 0.0);

                foreach (var team in teamList)
                {
                    var teamId = team.TeamId;
                    var iata = team.iata;
                    var originalIata = context.Teams.Where(x => x.TeamId == teamId).Select(x => x.iata).FirstOrDefault();

                    if (iata != originalIata)
                    {
                        teamsunabletoreturntohomeairport.Add(context.Teams.Where(x => x.TeamId == teamId).FirstOrDefault());
                    }


                }


                foreach (DataGridViewRow row in rows)
                {
                    if (row.Cells["Flight Number"].Value != null && row.Cells["Flight Number"].Value.ToString() != "")
                    {
                        var flightId = row.Cells["Flight Number"].Value.ToString();
                        var flight = context.Flights.Where(x => x.flightId == flightId).FirstOrDefault();
                        var teamId = row.Cells["Team Number"].Value?.ToString();
                        int? teamIdInt = null;
                        if (teamId != "")
                        {
                            teamIdInt = int.Parse(teamId.ToString());
                            //var team = context.Teams.Where(x => x.TeamId == teamIdInt).FirstOrDefault()

                        }
                        var flightRoster = new FlightRoster
                        {
                            flightId = flightId,
                            teamId = teamIdInt
                        };
                        var teams = context.Teams.ToList();
                        context.FlightRosters.Add(flightRoster);
                        context.SaveChanges();

                    }
                }


                foreach (DataGridViewRow row in rows)
                {
                    if (row.Cells["Flight Number"].Value != null && row.Cells["Flight Number"].Value.ToString() != "")
                    {
                        var flightId = row.Cells["Flight Number"].Value.ToString();
                        var flight = context.Flights.Where(x => x.flightId == flightId).FirstOrDefault();
                        var teamId = row.Cells["Team Number"].Value?.ToString();
                        int? teamIdInt = null;



                        if (teamId != "")
                        {
                            teamIdInt = int.Parse(teamId.ToString());
                            //var team = context.Teams.Where(x => x.TeamId == teamIdInt).FirstOrDefault();
                            
                            if (!teamtotalactivedutyhours.ContainsKey((int)teamIdInt))
                            {
                                teamtotalactivedutyhours.Add((int)teamIdInt, 0);
                            }
                            teamtotalactivedutyhours[(int)teamIdInt] += Double.Parse(TimeSpan.FromMinutes(flight.Duration_minutes).TotalHours.ToString());                                // Rest of the code...

                            int teamIdtoCheck = (int)teamIdInt;


                            var lastFlights = context.FlightRosters
                            .Where(fr => fr.teamId == teamIdtoCheck &&
                                fr.Flight.Date.Month == flight.Date.Month && 
                                fr.Flight.Date.Year == flight.Date.Year
                                && fr.flightId != flightId
                                && DateTime.Compare(fr.Flight.Date, flight.Date) < 0
                            )
                            .OrderByDescending(fr => fr.Flight.Date)
                            .ThenByDescending(fr => fr.Flight.Time)
                            .ToList();

                            FlightRoster lastFlight = null;

                            if(lastFlights.Count() >= 1)
                            {
                                lastFlight = lastFlights[0];
                            }


                            if (lastFlight != null)
                            {
                                {
                                    var lastFlightEndTime = lastFlight.Flight.Date + lastFlight.Flight.Time + TimeSpan.FromMinutes(lastFlight.Flight.Duration_minutes);
                                    var lastFlightStartTime = lastFlight.Flight.Date + lastFlight.Flight.Time;

                                    var restNeeded = Math.Ceiling(((lastFlightEndTime - lastFlightStartTime).TotalHours / 16)) * 10;

                                    var currentFlightStartTime = flight.Date + flight.Time;

                                    var rest  = (currentFlightStartTime - lastFlightEndTime).TotalHours;

                                    if (rest < restNeeded)
                                    {
                                        flightrecordsviolatedRestPeriod.Add(flight);
                                    }
                                }
                            }

                        }
                        else
                        {
                            flightrecordsunabletoroster.Add(flight);
                        }
                    }
                }
                MessageBox.Show("Flight Roster Saved");
                var month = monthpicker.Value.Month;
                var year = yearpicker.Value.Year;
                var dateRostered = new DateRostered
                {
                    date = new DateTime(year, month, 1)
                };
                context.DateRostereds.Add(dateRostered);
                context.SaveChanges();
                
                



               

                flightsrecordsunabletoregisterbs.DataSource = flightrecordsunabletoroster.Distinct().ToList();
                teamsunabletoreturntohomeairportbs.DataSource= teamsunabletoreturntohomeairport.Distinct().ToList();
                flightrecordsviolatedRestPeriodbs.DataSource= flightrecordsviolatedRestPeriod.Distinct().Select(x=> new
                {
                    x.flightId,
                    x.FlightRosters.ToList().FirstOrDefault().Team.TeamId,
                }).OrderBy(x=>x.TeamId).ToList();
                teamtotalactivedutyhoursbs.DataSource = teamtotalactivedutyhours.Select(x=> new
                {
                    TeamId = x.Key,
                    TotalActiveDutyHours = x.Value
                });


                dgvflightsunabletoroster.DataSource = flightsrecordsunabletoregisterbs;
                dgvteamsunabletoreturntoairport.DataSource = teamsunabletoreturntohomeairportbs;
                dgvflightrecordsrestperiod.DataSource = flightrecordsviolatedRestPeriodbs;
                dgvtotalactivehours.DataSource = teamtotalactivedutyhoursbs;

                lbfightrecordsunabletoregister.Text = "Number of Flight Records: " + flightrecordsunabletoroster.Count().ToString();
                lbteamsunabletoreturntohomeairport.Text = "Number of Teams: " + teamsunabletoreturntohomeairport.Count().ToString();
                lbflightrecordsviolatedrestperiod.Text = "Number of Flight Records:  " + flightrecordsviolatedRestPeriod.Count().ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has occured");
            }

    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all data and reset the form
            //dgvflights.DataSource = null;
            //flightsbs.DataSource = null;
            //dgvflightsunabletoroster.DataSource = null;
            //flightsrecordsunabletoregisterbs.DataSource = null;
            //dgvteamsunabletoreturntoairport.DataSource = null;
            //teamsunabletoreturntohomeairportbs.DataSource = null;
            //dgvflightrecordsrestperiod.DataSource = null;
            //flightrecordsviolatedRestPeriodbs.DataSource = null;
            //dgvtotalactivehours.DataSource = null;
            //teamtotalactivedutyhoursbs.DataSource = null;

            //// Reset the month and year pickers
            //monthpicker.Value = DateTime.Now;
            //yearpicker.Value = DateTime.Now;

            // Reset any other form elements or variables as needed

            // Reload the flights

            FrmFlightRosterManagement frm = new FrmFlightRosterManagement();
            frm.Show();
            this.Hide();

        }

        private void dgvflightrecordsrestperiod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvteamsunabletoreturntoairport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbteamsunabletoreturntohomeairport_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }

        private void btndeletersoter_Click(object sender, EventArgs e)
        {
            FrmDeleteRoster frm = new FrmDeleteRoster();
            frm.Show();
            this.Hide();

        }
    }
}
