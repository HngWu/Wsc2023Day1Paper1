using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsc2023Day1Paper1
{
    public partial class FrmCrewManagement : Form
    {
        Wsc2023Day1Paper1DbContext context = new Wsc2023Day1Paper1DbContext();
        BindingSource bs = new BindingSource();

        public int previousCrewNumber; 

      public FrmCrewManagement()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Set the font size of the DataGridView cells
            dgvcrews.DefaultCellStyle.Font = new Font("Cambria", 16);

            var countries = context.Airports.Select(a => a.country_code).Distinct().ToArray();
            var airports = context.Airports.Where(a => a.country_code == cbcountry.Text.ToString() || string.IsNullOrEmpty(cbcountry.Text.ToString()))
                .Select(x => x.airport1).ToArray();

            cbcountry.Items.AddRange(countries);
            cbairport.Items.AddRange(airports);

            LoadData();
            DataGridViewLinkColumn editlink = new DataGridViewLinkColumn();
            editlink.UseColumnTextForLinkValue = true;
            editlink.HeaderText = "Edit";
            editlink.Name = "Edit";
            editlink.DataPropertyName = "lnkColumn";
            editlink.LinkBehavior = LinkBehavior.SystemDefault;
            editlink.Text = "Edit";
            dgvcrews.Columns.Add(editlink);

            DataGridViewLinkColumn deletelink = new DataGridViewLinkColumn();
            deletelink.UseColumnTextForLinkValue = true;
            deletelink.HeaderText = "Delete";
            deletelink.Name = "Delete";
            deletelink.DataPropertyName = "lnkColumn";
            deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            deletelink.Text = "Delete";
            dgvcrews.Columns.Add(deletelink);
        }


        public void LoadData()
        {
            var crewList = context.Crews
                .Select(c => new
                {
                    c.Crew_Number,
                    c.Gender,
                    c.Name,
                    c.Type,
                    c.Home_Port_IATA,
                    TeamId = (c.TeamAssigneds.Select(x => x.teamId.ToString()).DefaultIfEmpty("").FirstOrDefault())
                })
                .ToList();

            DataTable dt = new DataTable();

            // Add columns to the DataTable
            dt.Columns.Add("Crew_Number", typeof(int));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Home_Port_IATA", typeof(string));
            dt.Columns.Add("TeamId", typeof(string));

            // Populate the DataTable with data from the context.Crews collection
            foreach (var crew in crewList)
            {
               

                dt.Rows.Add(crew.Crew_Number, crew.Gender, crew.Name, crew.Type, crew.Home_Port_IATA, crew.TeamId);
            }

            // Bind the DataTable to the DataGridView
            dgvcrews.DataSource = dt;

        }

        public void clearForm()
        {
            tbcrewno.Text = "";
            tbgivenname.Text = "";
            tbsurname.Text = "";
            cbairport.Text = "";
            cbcountry.Text = "";
            cbcrewtype.Text = "";

            var airports = context.Airports.Where(a => a.country_code == cbcountry.Text.ToString() || string.IsNullOrEmpty(cbcountry.Text.ToString()))
               .Select(x => x.airport1).ToArray();
            cbairport.Items.AddRange(airports);


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == dgvcrews.Columns["Edit"].Index)
                {
                    int id = Convert.ToInt32(dgvcrews.Rows[e.RowIndex].Cells["Crew_Number"].Value);
                    Crew crew = context.Crews.Find(id);
                    previousCrewNumber = crew.Crew_Number;


                    tbcrewno.Text = crew.Crew_Number.ToString();
                    var fullName = crew.Name.Split(' ');

                    if(fullName.Length > 1)
                    {
                        tbgivenname.Text = fullName[0];
                        tbsurname.Text = string.Join(" ", fullName.Skip(1));
                    }
                    else
                    {
                        tbgivenname.Text = fullName[0];
                        tbsurname.Text = "";
                    }
                    cbgender.Text = crew.Gender.ToString();
                    cbairport.Text = crew.Airport.airport1.ToString();
                    cbcountry.Text = crew.Airport.country_code;
                    cbcrewtype.Text = crew.Type.ToString();

                    var filteredAirports = context.Airports.Where(a => a.country_code == cbcountry.Text.ToString() || string.IsNullOrEmpty(cbcountry.Text.ToString()))
                       .Select(x => x.airport1).ToArray(); cbairport.Items.Clear();
                    cbairport.Items.AddRange(filteredAirports);



                }
                else if(e.ColumnIndex == dgvcrews.Columns["Delete"].Index)
                {
                    int id = Convert.ToInt32(dgvcrews.Rows[e.RowIndex].Cells["Crew_Number"].Value);
                    Crew crew = context.Crews.Find(id);

                    if (crew.TeamAssigneds.Where(x => x.crewId == id).Select(x => x.teamId) == null || crew.TeamAssigneds.Where(x=>x.crewId == id).Select(x => x.teamId).Count() == 0 )
                    {
                        context.Crews.Remove(crew);
                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Crew deleted successfully");
                        
                    }

                    else
                    {
                        MessageBox.Show("Error: Crew is assigned to a team. Cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                 
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error Occured due to misclick");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }

        private void FrmCrewManagement_Load(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {

            if(int.TryParse(tbcrewno.Text, out int result) == false)
            {
                MessageBox.Show("Error: Crew Number must be a number");
                return;
            }
            var crewNo = Convert.ToInt32(tbcrewno.Text);


            try
            {
                var isdulplicate = context.Crews.Any(x=>x.Crew_Number == crewNo);
                if (isdulplicate)
                {
                    MessageBox.Show("Error: Crew Number already exists");
                    return;
                }
                else if (tbcrewno.Text == "" || tbgivenname.Text == "" || tbsurname.Text == "" || cbgender.Text == "" || cbcrewtype.Text == "" || cbairport.Text == "")
                {
                    MessageBox.Show("Error: Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var iata = context.Airports.FirstOrDefault(a => a.airport1 == cbairport.Text.ToString()).iata;

                    var crew = new Crew
                    {
                        Crew_Number = crewNo,
                        Name = tbgivenname.Text.ToString() +" " + tbsurname.Text.ToString(),
                        Home_Port_IATA = iata,
                        Type = cbcrewtype.Text.ToString(),
                        Gender = cbgender.Text.ToString()
                    };
                    context.Crews.Add(crew);
                    context.SaveChanges();
                    LoadData();
                    clearForm();
                    MessageBox.Show("Crew created successfully");
                }



            }
            catch (Exception)
            {
                
                MessageBox.Show("Error: Crew cannot be saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredAirports = context.Airports.Where(a => a.country_code == cbcountry.Text.ToString() || string.IsNullOrEmpty(cbcountry.Text.ToString()))
                       .Select(x => x.airport1).ToArray(); cbairport.Items.Clear();
            cbairport.Items.AddRange(filteredAirports);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbcrewno.Text, out int result) == false)
            {
                MessageBox.Show("Error: Crew Number must be a number");
                return;
            }
            var crewNo = Convert.ToInt32(tbcrewno.Text);
            var previousCrewNo = previousCrewNumber;



            try
            {
                var isdulplicate = context.Crews.Any(x => x.Crew_Number == crewNo);
                if (isdulplicate && crewNo != previousCrewNo)
                {
                    MessageBox.Show("Error: Crew Number already exists");
                    return;
                }
                else if (tbcrewno.Text == "" || tbgivenname.Text == "" || tbsurname.Text == "" || cbgender.Text == "" || cbcrewtype.Text == "" || cbairport.Text == "")
                {
                    MessageBox.Show("Error: Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                else
                {
                    var iata = context.Airports.FirstOrDefault(a => a.airport1 == cbairport.Text.ToString()).iata;

                    var crew = new Crew
                    {
                        Crew_Number = crewNo,
                        Name = tbgivenname.Text.ToString() + " " + tbsurname.Text.ToString(),
                        Home_Port_IATA = iata,
                        Type = cbcrewtype.Text.ToString(),
                        Gender = cbgender.Text.ToString()
                    };
                    context.Crews.AddOrUpdate(crew);
                    context.SaveChanges();
                    LoadData();
                    clearForm();

                    MessageBox.Show("Crew updated successfully");
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Error: Crew cannot be updated successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }
    }
}
