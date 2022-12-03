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
    public partial class Students : Sample
    {
        string UName;
        public Students(string name)
        {
            InitializeComponent();
            AutoSearch();
            this.UName = name;
        }
        public string constring = "Data Source=DESKTOP-1K7RKPF\\SQLEXPRESS;Initial Catalog=SMdemodb;Integrated Security=True";

        public void AutoSearch()
        {
            toolStripTextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripTextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(constring);
            string query = "Select Name,FatherName from Students ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    coll.Add(myreader.GetString(0));
                    coll.Add(myreader.GetString(1));

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            toolStripTextBox1.AutoCompleteCustomSource = coll;
            con.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);//actual start
            if (toolStripTextBox1.Text != "")
            {
                con.Open();
                try
                {

                    /* SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students where Name='" + toolStripTextBox1.Text + "' or FatherName='" + toolStripTextBox1.Text + "'", con);
                     DataSet ds = new DataSet();
                     da.Fill(ds, "Students");
                     //dataGridView1.DataSource = ds.Tables["Students"].DefaultView;
                     picLoad();
                     infoLoad();
                     //StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\Images\" + toolStripTextBox1.Text+".png");
                    */
                    String query = ("SELECT RegNumber,Name,FatherName,Address,Email,StudentContact#,RefName,GuardianContact#,Age,CNIC,Class,DOB,BloodGroup,Gender,Transportation,Scholarship,AdmissionDate from Students where Name='" + toolStripTextBox1.Text + "' or FatherName='" + toolStripTextBox1 + "'");
                    SqlCommand SDA = new SqlCommand(query, con);

                    SqlDataReader data = SDA.ExecuteReader();
                    if (data.Read())
                    {
                        txtRegNumber.Text = data.GetValue(0).ToString();
                        txtName.Text = data.GetValue(1).ToString();
                        txtFatherName.Text = data.GetValue(2).ToString();
                        TxtAddress.Text = data.GetValue(3).ToString();
                        txtEmail.Text = data.GetValue(4).ToString();
                        txtstdContactNumber.Text = data.GetValue(5).ToString();
                        txtReferenceNumber.Text = data.GetValue(6).ToString();
                        txtFatherMobileNumber.Text = data.GetValue(7).ToString();
                        txtAge.Text = data.GetValue(8).ToString();
                        txtcnic.Text = data.GetValue(9).ToString();
                        comboboxClass.Text = data.GetValue(10).ToString();
                        DOBpicker.Text = data.GetValue(11).ToString();
                        txtBloodGroup.Text = data.GetValue(12).ToString();
                        comboboxgender.Text = data.GetValue(13).ToString();
                        txtTransportation.Text = data.GetValue(14).ToString();
                        txtScholarship.Text = data.GetValue(15).ToString();
                        datepickerAdmission.Text = data.GetValue(16).ToString();
                        
                    }
                    picLoad();
                  

                    // StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\SMDemo\SMDemo\Images\" + PicNumber + ".png");

                    con.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                finally
                {
                    con.Close();
                }//actual end
            }


        }

        public void picLoad()
        {//pic load from certain path
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            int PicNumber = 0;
            try
            {
                String query = ("SELECT RegNumber from Students where Name='" + toolStripTextBox1.Text + "' or FatherName='" + toolStripTextBox1.Text + "'");
                SqlCommand SDA = new SqlCommand(query, conn);

                SqlDataReader data = SDA.ExecuteReader();
                if (data.Read())
                {
                    PicNumber = Convert.ToInt32(data.GetValue(0).ToString());
                }
                StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\Images\" + PicNumber + ".png");

                conn.Close();
            }
            catch (Exception exp)
            {

            }


        }
        public void infoLoad()
        {//information load to gridview
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            // int PicNumber = 0;
            try
            {
                String query = ("SELECT RegNumber,Name,Class from Students where Name='" + toolStripTextBox1.Text + "' or FatherName='" + toolStripTextBox1 + "'");
                SqlCommand SDA = new SqlCommand(query, conn);

                SqlDataReader data = SDA.ExecuteReader();
                if (data.Read())
                {
                  /*  lblRegNumber.Text = data.GetValue(0).ToString();
                    lblStudentName.Text = data.GetValue(1).ToString();
                    lblStdclassdisply.Text = data.GetValue(2).ToString();*/
                }

                // StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\SMDemo\SMDemo\Images\" + PicNumber + ".png");

                conn.Close();
            }
            catch (Exception exp)
            {

            }

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {//for update button to update data
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd;
            try
            {
                string qr = "UPDATE Students SET Name = @name ,FatherName=@fatherName,Address=@Address,Email=@Email,StudentContact#=@Student#,RefName=@RefName,GuardianContact#=@Guardian#,Age=@Age,CNIC=@CNIC#,Class=@Class,DOB=@DOB,BloodGroup=@BloodGroup,Gender=@Gender,Transportation=@Transport,Scholarship=@Scholarship WHERE RegNumber='" + txtRegNumber.Text+"'";
                cmd = new SqlCommand(qr, con);
                cmd.Parameters.AddWithValue("@name", Convert.ToString(txtName.Text));
                cmd.Parameters.AddWithValue("@fatherName", Convert.ToString(txtFatherName.Text));
                cmd.Parameters.AddWithValue("@Address", Convert.ToString(TxtAddress.Text));
                cmd.Parameters.AddWithValue("@Email", Convert.ToString(txtEmail.Text));
                cmd.Parameters.AddWithValue("@Student#", Convert.ToString(txtstdContactNumber.Text));
                cmd.Parameters.AddWithValue("@RefName", Convert.ToString(txtReferenceNumber.Text));
                cmd.Parameters.AddWithValue("@Guardian#", Convert.ToString(txtFatherMobileNumber.Text));
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@CNIC#", Convert.ToString(txtcnic.Text));
                cmd.Parameters.AddWithValue("@Class", Convert.ToString(comboboxClass.Text));
                cmd.Parameters.AddWithValue("@DOB", DOBpicker.Value);
                cmd.Parameters.AddWithValue("@AdmissionDate", datepickerAdmission.Value);
                cmd.Parameters.AddWithValue("@BloodGroup", Convert.ToString(txtBloodGroup.Text));
                cmd.Parameters.AddWithValue("@Gender", Convert.ToString(comboboxgender.Text));
                cmd.Parameters.AddWithValue("@Transport", Convert.ToString(txtTransportation.Text));
                cmd.Parameters.AddWithValue("@Scholarship", Convert.ToString(txtScholarship.Text));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data is Updated", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AutoSearch();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(txtRegNumber.Text == String.Empty))
            {
                DialogResult result = MessageBox.Show("Are You Sure, You want to delete This Student Record", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (!(txtRegNumber.Text == string.Empty))
                    {

                        SqlConnection con = new SqlConnection(constring);
                        string query = "Delete from Students where RegNumber='" + txtRegNumber.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader myreader;
                        try
                        {
                            con.Open();
                            myreader = cmd.ExecuteReader();
                            MessageBox.Show("Successfully Student Record Deleted", "Information");
                            while (myreader.Read())
                            {
                            }
                            AutoSearch();
                            ClearTextBoxData();
                            con.Close();
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show(ec.Message);
                        }

                    }
                   
                }
                else
                {
                    MessageBox.Show("Operation Cancelled", "Information");
                }
            }
            else
            {
                MessageBox.Show("Please Select A student First", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }//delete button end here

        public void ClearTextBoxData()
        {
            txtcnic.Clear();
            txtFatherMobileNumber.Clear();
            txtFatherName.Clear();
            txtName.Clear();
            txtReferenceNumber.Clear();
            txtstdContactNumber.Clear();
            txtTransportation.Clear();
            TxtAddress.Clear();
            txtRegNumber.Clear();
            txtScholarship.Clear();
            txtAge.Clear();
            txtBloodGroup.Clear();
            comboboxgender.Text = "";
            comboboxClass.Text = "";
            txtEmail.Clear();

            StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\Images\alt.png");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard std = new DashBoard(UName);
            std.MdiParent = this.MdiParent;
            std.WindowState = FormWindowState.Maximized;
            std.Show();
        }
    }
    
}
