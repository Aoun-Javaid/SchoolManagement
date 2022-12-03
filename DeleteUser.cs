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
    public partial class DeleteUser : Sample
    {
        public string UName;
        public DeleteUser(string UName)
        {
            InitializeComponent();
            this.UName = UName;
        }
        public string constring = "Data Source=DESKTOP-1K7RKPF\\SQLEXPRESS;Initial Catalog=SMdemodb;Integrated Security=True";

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMdemodbDataSet1.UserAcces' table. You can move, or remove it, as needed.
            this.userAccesTableAdapter.Fill(this.sMdemodbDataSet1.UserAcces);
            txtPassword.Text = "";
            txtUsername.Text = "";
            AutoSearch();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Settings std = new Settings(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Enter Username to delete");
            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Please enter password");
            }
            else
            { 
            DialogResult result = MessageBox.Show("Are You Sure,You want to delete this User? ", " Important", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
            }//actual code
            else
            {
                    
                    
                        SqlConnection con = new SqlConnection(constring);
                        string query = "Delete from UserAcces where UserName= '" + this.txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader myreader;

                        try
                        {
                            con.Open();
                            myreader = cmd.ExecuteReader();

                            // MessageBox.Show("successfully User Deleted ...!","Important",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            while (myreader.Read())
                            {
                            }
                            deleteUSerQuestions(sender, e);
                            con.Close();
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show(ec.Message, "Exception Found UAT");
                        }
                    
                   
                }
            }
        }

        public void deleteUSerQuestions(object sender, EventArgs e)//method that deletes Extra security question belong to certain user
        {
            SqlConnection cn = new SqlConnection(constring);
            string qr = "Delete from UserPersonal where UserName= '" + this.txtUsername.Text + "'";
            SqlCommand cmd2 = new SqlCommand(qr, cn);
            SqlDataReader myreader2;
            try
            {
                cn.Open();
                myreader2 = cmd2.ExecuteReader();
                while (myreader2.Read())
                {
                }
                MessageBox.Show("successfully User Deleted ...!", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeleteUser_Load(sender, e);
                cn.Close();

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Exception Found UPT");
            }


        }
        public void AutoSearch()
        {
            txtUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(constring);
            string query = "Select UserName from UserAcces ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    coll.Add(myreader.GetString(0));
                   

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            txtUsername.AutoCompleteCustomSource = coll;
            con.Close();
        }

    }
}
