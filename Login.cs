using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssignmentVpSMS
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-1K7RKPF\\SQLEXPRESS;Initial Catalog=SMdemodb;Integrated Security=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserAcces where UserName ='" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                DashBoard lgn = new DashBoard(txtUsername.Text);
                lgn.MdiParent = this.MdiParent;
                lgn.WindowState = FormWindowState.Maximized;
                lgn.Show();

            }
            else
            {
                errorProvider1.SetError(txtUsername, "Please Enter correct UserName and Password");
                // MessageBox.Show("please check your Username and Password...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
