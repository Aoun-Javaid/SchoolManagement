using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentVpSMS
{
    public partial class DashBoard : Sample
    {
        public string UName;
        public DashBoard(string UserName)
        {
            InitializeComponent();
            UName = UserName;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admission adm = new Admission(UName);
            adm.MdiParent = this.MdiParent;
            adm.WindowState = FormWindowState.Maximized;
            adm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students std = new Students(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff std = new Staff(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings stg = new Settings(UName);
            stg.MdiParent = this.MdiParent;
            stg.WindowState = FormWindowState.Maximized;
            stg.Show();
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not available in free mode ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not available in free mode ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTimeTables_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not available in free mode ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not available in free mode ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            Finance stg = new Finance(UName);
            stg.MdiParent = this.MdiParent;
            stg.WindowState = FormWindowState.Maximized;
            stg.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            lblUName.Text = UName;
        }

       
    }
}
