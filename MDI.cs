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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.MdiParent = this;
            lgn.WindowState = FormWindowState.Maximized;
            lgn.Show();
            
            
            
            


        }

       

       

        private void logoutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.MdiParent = this;
            lo.WindowState = FormWindowState.Maximized;
            lo.Show();
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
