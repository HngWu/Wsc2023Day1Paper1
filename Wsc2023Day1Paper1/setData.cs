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
    public partial class setData : Form
    {
        Wsc2023Day1Paper1DbContext context = new Wsc2023Day1Paper1DbContext();  
        public setData()
        {
            InitializeComponent();
        }

        private void setData_Load(object sender, EventArgs e)
        {

            var teams = context.Teams.ToList();


            foreach (var team in teams)
            {
                var crew = context.TeamAssigneds.Where(c => c.teamId == team.TeamId).FirstOrDefault();

                var iata = context.Crews.Where(c => c.Crew_Number == crew.crewId).FirstOrDefault().Home_Port_IATA;
                team.iata = iata;
                context.Teams.AddOrUpdate(team);
                context.SaveChanges();

            }

        }
    }
}
