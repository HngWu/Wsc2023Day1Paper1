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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void btncrew_Click(object sender, EventArgs e)
        {
            FrmCrewManagement frm = new FrmCrewManagement();
            frm.Show();
            this.Hide();
        }

        private void btnteams_Click(object sender, EventArgs e)
        {
            FrmTeamManagement frm = new FrmTeamManagement();
            frm.Show();
            this.Hide();
        }

        private void tbflightroster_Click(object sender, EventArgs e)
        {
            FrmFlightRosterManagement frm = new FrmFlightRosterManagement();
            frm.Show();
            this.Hide();
        }
    }
}
