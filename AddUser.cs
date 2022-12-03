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
    public partial class AddUser : Sample
    {
        public String UName;
        public AddUser(string name)
        {
            InitializeComponent();
            UName = name;
            
        }

        public string constring = "Data Source=DESKTOP-1K7RKPF\\SQLEXPRESS;Initial Catalog=SMdemodb;Integrated Security=True";

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            

            
            try
            {
               
                if (txtname.Text != "")
                {
                    if (txtPassword.Text != "")
                    {


                        if (txtFavtPerson.Text != "")
                        {
                            if (txtAge.Text != "")
                            {
                                if (txtBestFriend.Text != "")
                                {
                                    if (txtcityborn.Text != "")
                                    {
                                        if (txtgfbf.Text != "")
                                        {

                                            // CheckPassword cp = new CheckPassword(UName, txtname.Text, txtPassword.Text, txtFavtPerson.Text, txtAge.Text, txtBestFriend.Text, txtcityborn.Text, txtgfbf.Text);

                                            // cp.Show();
                                            MessageBox.Show("You have to enter your password to Confirm this action...!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            NuserData();
                                            Confirmation();

                                           
                                                
                                            
                                           //geting some value in return thatswhy we can call clear value method from here
                                        }
                                        else
                                        {
                                            MessageBox.Show("Your GF/BF name is missing...!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your born city is missing", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Bestfriend name is missing", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show(" Age is missing", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("favourite Person name is missing", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Password is missing", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(" User Name is missing ", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error Occured!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           

        }
        public void Clearfields()
        {
            txtAge.Text = "";
            txtBestFriend.Text = "";
            txtcityborn.Text = "";
            txtFavtPerson.Text = "";
            txtgfbf.Text = "";
            txtname.Text = "";
            txtPassword.Text = "";
        }
        public void Confirmation()
        {
            lblUtag.Text ="Dear "+ UName +",";
            lblUtag.Visible = true;
            lblCnfrmPaas.Visible = true;
            txtConfirmPassword.Visible = true;
            btnSubmit.Visible = true;
        }
        public void NuserData()
        {
            txtAge.Visible = false;
            txtBestFriend.Visible = false;
            txtcityborn.Visible = false;
            txtFavtPerson.Visible = false;
            txtgfbf.Visible = false;
            txtname.Visible = false;
            txtPassword.Visible = false;
            btnCreateAccount.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Settings std = new Settings(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
                if (allow() == true)
                {

                    SqlConnection con = new SqlConnection(constring);
                    SqlCommand cmd;
                    SqlCommand cmd2;
                    con.Open();
                    string s = "insert into UserAcces (UserName,Password) values(@name,@pass)";
                    string qr2 = "insert into UserPersonal values(@name,@favtPerson,@Age,@Bestfriend,@bornCity,@firstLove)";
                    cmd = new SqlCommand(s, con);
                    cmd2 = new SqlCommand(qr2, con);
                    try
                    {

                       cmd.Parameters.AddWithValue("@name", Convert.ToString(txtname.Text));
                        cmd.Parameters.AddWithValue("@pass", Convert.ToString(txtPassword.Text));
                        cmd2.Parameters.AddWithValue("@name", Convert.ToString(txtname.Text));
                        cmd2.Parameters.AddWithValue("@favtPerson", Convert.ToString(txtFavtPerson.Text));
                        cmd2.Parameters.AddWithValue("@Age", Convert.ToString(txtAge.Text));
                        cmd2.Parameters.AddWithValue("@Bestfriend", Convert.ToString(txtBestFriend.Text));
                        cmd2.Parameters.AddWithValue("@bornCity", Convert.ToString(txtcityborn.Text));
                        cmd2.Parameters.AddWithValue("@firstLove", Convert.ToString(txtgfbf.Text));

                        cmd2.CommandType = CommandType.Text;
                        cmd2.ExecuteNonQuery();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User is Registered Succesfully ", "Mubarkaan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBack_Click(sender, e);
                        con.Close();





                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password...! Retry Again", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public Boolean allow()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserAcces where UserName ='" + UName + "' and Password ='" + txtConfirmPassword.Text + "' ", con);
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
