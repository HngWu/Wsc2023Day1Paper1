using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsc2023Day1Paper1
{
    public partial class FrmCreateTeam : Form
    {
        Wsc2023Day1Paper1DbContext context = new Wsc2023Day1Paper1DbContext();
        BindingSource selectedCrewbs = new BindingSource();
        BindingSource crewmembersbs = new BindingSource();

        public FrmCreateTeam()
        {
            InitializeComponent();
            var countries = context.Airports.Select(a => a.country_code).Distinct().ToArray();
            var airports = context.Airports.Where(a => a.country_code == cbcountry.Text.ToString() || string.IsNullOrEmpty(cbcountry.Text.ToString()))
                .Select(x => x.airport1).ToArray();

            cbcountry.Items.AddRange(countries);
            cbairport.Items.AddRange(airports);

            dgvcrewavailable.DefaultCellStyle.Font = new Font("Cambria", 16);
            dgvselectedcrew.DefaultCellStyle.Font = new Font("Cambria", 16);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var crewNumberList = new List<int>();
            var crewList = new List<Crew>();
            var rows = dgvselectedcrew.Rows;

            foreach (DataGridViewRow row in rows)
            {
                crewNumberList.Add(int.Parse(row.Cells["Crew_Number"].Value.ToString()));
            }
            foreach(var crewNumber in crewNumberList)
            {
                var crew = context.Crews.Where(x => x.Crew_Number == crewNumber).FirstOrDefault();
                crewList.Add(crew);
            }

            if(crewList.Where(x=>x.Type == "Cockpit").Count() > 1)
            {
                if(int.TryParse(tbteamno.Text, out int teamId) == false)
                {
                    MessageBox.Show("Error: Team Number must be a number");
                    return;
                }
                else if(context.Teams.Where(x=>x.TeamId == teamId).Count() > 0)
                {
                    MessageBox.Show("Error: Team Number already exists");
                    return;
                }
                else
                {
                    var newTeam = new Team
                    {
                        TeamId = teamId,
                        iata = context.Airports.Where(x => x.airport1 == cbairport.Text.ToString()).Select(x => x.iata).FirstOrDefault()
                    };

                    context.Teams.Add(newTeam);
                    context.SaveChanges();



                    foreach (var crew in crewList)
                    {
                        var teamAssigned = new TeamAssigned
                        {
                            crewId = crew.Crew_Number,
                            teamId = teamId
                        };
                        context.TeamAssigneds.Add(teamAssigned);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Team Created Successfully");
                    FrmTeamManagement frm = new FrmTeamManagement();
                    frm.Show();
                    this.Hide();

                }
                

            }
            else
            {
                MessageBox.Show("Error: Need to have More than one cockpit crew selected");

            }


        }

        private void cbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var airports = context.Airports.Where(a => a.country_code == cbcountry.Text.ToString() || string.IsNullOrEmpty(cbcountry.Text.ToString()))
                .Select(x => x.airport1).ToArray();
            cbairport.Items.Clear();
            cbairport.Items.AddRange(airports);

        }

        private void cbairport_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIata = context.Airports.Where(a => a.airport1 == cbairport.Text.ToString())
                .Select(x => x.iata).FirstOrDefault();
            var availableCrew = context.Crews
                .Where(x => x.TeamAssigneds.Count == 0 && x.Home_Port_IATA == selectedIata)
                .Select(x => new
                {
                    x.Crew_Number,
                    x.Name,
                    x.Type,
                    x.Home_Port_IATA
                }).ToList();

            crewmembersbs.DataSource = availableCrew;
            dgvcrewavailable.DataSource = crewmembersbs;

        }

        private void btnrightall_Click(object sender, EventArgs e)
        {

            try
            {
                var selectedRows = dgvcrewavailable.SelectedRows;

                foreach (DataGridViewRow row in selectedRows)
                {
                    var crewNumber = int.Parse(row.Cells["Crew_Number"].Value.ToString());
                    var crew = context.Crews.Where(x => x.Crew_Number == crewNumber).Select(x => new
                    {
                        x.Crew_Number,
                        x.Name,
                        x.Type,
                        x.Home_Port_IATA
                    }).FirstOrDefault();
                    selectedCrewbs.Add(crew);
                    crewmembersbs.Remove(crew);
                    dgvcrewavailable.DataSource = crewmembersbs;
                    dgvselectedcrew.DataSource = selectedCrewbs;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error: No Rows Selected");
            }

           
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgvcrewavailable.SelectedRows[0];


                var crewNumber = int.Parse(row.Cells["Crew_Number"].Value.ToString());
                var crew = context.Crews.Where(x => x.Crew_Number == crewNumber).Select(x => new
                {
                    x.Crew_Number,
                    x.Name,
                    x.Type,
                    x.Home_Port_IATA
                }).FirstOrDefault();
                selectedCrewbs.Add(crew);
                crewmembersbs.Remove(crew);
                dgvcrewavailable.DataSource = crewmembersbs;
                dgvselectedcrew.DataSource = selectedCrewbs;

            }
            catch (Exception)
            {

                MessageBox.Show("Error: No Rows Selected");
            }
            
            
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgvselectedcrew.SelectedRows[0];


                var crewNumber = int.Parse(row.Cells["Crew_Number"].Value.ToString());
                var crew = context.Crews.Where(x => x.Crew_Number == crewNumber).Select(x => new
                {
                    x.Crew_Number,
                    x.Name,
                    x.Type,
                    x.Home_Port_IATA
                }).FirstOrDefault();
                crewmembersbs.Add(crew);
                selectedCrewbs.Remove(crew);
                dgvcrewavailable.DataSource = crewmembersbs;
                dgvselectedcrew.DataSource = selectedCrewbs;
            }
            catch (Exception)
            {

                MessageBox.Show("Error: No Rows Selected");
            }



        }

        private void btnleftall_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dgvselectedcrew.SelectedRows;

                foreach (DataGridViewRow row in selectedRows)
                {
                    var crewNumber = int.Parse(row.Cells["Crew_Number"].Value.ToString());
                    var crew = context.Crews.Where(x => x.Crew_Number == crewNumber).Select(x => new
                    {
                        x.Crew_Number,
                        x.Name,
                        x.Type,
                        x.Home_Port_IATA
                    }).FirstOrDefault();
                    crewmembersbs.Add(crew);
                    selectedCrewbs.Remove(crew);
                    dgvcrewavailable.DataSource = crewmembersbs;
                    dgvselectedcrew.DataSource = selectedCrewbs;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error: No Rows Selected");
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmTeamManagement frm = new FrmTeamManagement();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }

        private void dgvcrewavailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
