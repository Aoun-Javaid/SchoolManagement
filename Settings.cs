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
    public partial class Settings : Sample
    {
        public string UName;
        public Settings(string name)
        {
            InitializeComponent();
            UName = name;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddUser nu = new AddUser(UName);
            nu.MdiParent = this.MdiParent;
            nu.WindowState = FormWindowState.Maximized;
            nu.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard std = new DashBoard(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            ChangePass cp = new ChangePass(UName);
            cp.Show();
         
          
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser std = new DeleteUser(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }
    }
}
