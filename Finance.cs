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
    public partial class Finance : Sample
    {
        public string UName;
        public Finance(string UName)
        {
            InitializeComponent();
            this.UName = UName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard std = new DashBoard(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            Fees std = new Fees(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }
    }
}
