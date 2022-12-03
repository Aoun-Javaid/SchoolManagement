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
    public partial class Fees : Sample
    {
        public string UName;
        public Fees(String UName)
        {
            InitializeComponent();
            this.UName = UName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Finance std = new Finance(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }

       
    }
}
