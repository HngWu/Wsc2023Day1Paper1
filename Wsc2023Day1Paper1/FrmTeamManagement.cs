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
    public partial class FrmTeamManagement : Form
    {
        Wsc2023Day1Paper1DbContext context = new Wsc2023Day1Paper1DbContext();
        BindingSource teamsbs = new BindingSource();
        BindingSource crewmembersbs = new BindingSource();

        public FrmTeamManagement()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dgvcrew.DefaultCellStyle.Font = new Font("Cambria", 16);
            dgvteams.DefaultCellStyle.Font = new Font("Cambria", 16);

            LoadTeams();


            DataGridViewLinkColumn dataGridViewLinkColumn = new DataGridViewLinkColumn();
            dataGridViewLinkColumn.HeaderText = "Delete";
            dataGridViewLinkColumn.Name = "Delete";
            dataGridViewLinkColumn.Text = "Delete";
            dataGridViewLinkColumn.UseColumnTextForLinkValue = true;
            dgvteams.Columns.Add(dataGridViewLinkColumn);


        }


        public void LoadTeams()
        {
            var crewTeams = context.Teams
                .Select(x => new
                {
                    x.TeamId,
                    x.iata,
                }).OrderBy(x => x.TeamId)
                .ToList();
            teamsbs.DataSource = crewTeams;
            dgvteams.DataSource = teamsbs;
        }

        private void FrmTeamManagement_Load(object sender, EventArgs e)
        {

        }
        public void LoadCrewMembers(int teamId)
        {
            var crewMembers = context.Crews
                .Where(x => x.TeamAssigneds.Select(y => y.teamId).FirstOrDefault() == teamId)
                    .Select(x => new
                    {
                        x.Crew_Number,
                        x.Name,
                        x.Type,
                    })
                .ToList();
            crewMembers = crewMembers
                .OrderBy(x => string.Join(" ", x.Name.Split(' ').Skip(1)))
            .ToList();
            crewMembers = crewMembers
           .OrderByDescending(x => x.Type)
           .ToList();

            crewmembersbs.DataSource = crewMembers;
            dgvcrew.DataSource = crewmembersbs;
        }

        private void dgvteams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvteams.Columns["Delete"].Index)
                {
                    var teamId = Convert.ToInt32(dgvteams.Rows[e.RowIndex].Cells["TeamId"].Value);
                    var team = context.Teams.Where(x => x.TeamId == teamId).FirstOrDefault();
                    

                    var TeamAssigneds = context.TeamAssigneds.Where(x => x.teamId == teamId).ToList();

                    if(team.FlightRosters.Count > 0)
                    {
                        MessageBox.Show("Error: Team has flight rosters");
                        return;
                    }
                    else
                    {
                        context.Teams.Remove(team);
                        context.TeamAssigneds.RemoveRange(TeamAssigneds);
                        context.SaveChanges();
                        LoadTeams();
                        MessageBox.Show("Team Deleted");
                    }

                    dgvcrew.DataSource = null;
            
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error: Misclick");
            }

        }

        private void dgvteams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvteams.Rows[e.RowIndex];

                var teamId = Convert.ToInt32(row.Cells["TeamId"].Value);
                LoadCrewMembers(teamId);


            }
            catch (Exception)
            {

                MessageBox.Show("Error: Misclick");
            }

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            FrmCreateTeam frm = new FrmCreateTeam();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }
    }
}
