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
    public partial class ChangePass : Form
    {
        public string UName;
        public ChangePass(String UName)
        {
            InitializeComponent();
            this.UName = UName;
            labelusername.Text = "Dear " + UName + ",";
        }
        public string constring = "Data Source=DESKTOP-1K7RKPF\\SQLEXPRESS;Initial Catalog=SMdemodb;Integrated Security=True";

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            try
            {//first fetch data and compare data with coming one
                if (allow() == true)
                {
                    DialogResult result = MessageBox.Show("Are You sure,You want to change your Password?", " Important", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
                    if (result != DialogResult.Yes)
                    {
                        txtNewPassword.Text = "";
                        txtOldPassword.Text = "";

                    }
                    else
                    {
                        SqlCommand cmdupdate = new SqlCommand("Update UserAcces SET Password='" + txtNewPassword.Text + "' where UserName='" + UName + "' and Password='" + txtOldPassword.Text + "'", con);
                        con.Open();
                        cmdupdate.CommandType = CommandType.Text;
                        int count = cmdupdate.ExecuteNonQuery();
                        if (count > 0)
                        {

                            MessageBox.Show("Password Change Sucessfully!!!", "Mubarkaan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Check Your UserName and Password!!!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    errorProvider1.SetError(txtOldPassword, "Password is incorrect");
                    txtOldPassword.Text = "";
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }

        }

        public Boolean allow()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserAcces where UserName ='" + UName + "' and Password ='" + txtOldPassword.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {

                return true;


            }
            else
            {
                return false;
            }
        }
    }
}
