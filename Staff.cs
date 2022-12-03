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
using System.IO;

namespace AssignmentVpSMS
{
    public partial class Staff : Sample2
    {
        public string UName;
        public Staff(string name)
        {
            InitializeComponent();
            this.UName = name;
        }
        public string fileAdress;
        Boolean gotIMage = false;
        public string constring = "Data Source=DESKTOP-1K7RKPF\\SQLEXPRESS;Initial Catalog=SMdemodb;Integrated Security=True";

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripTextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(constring);
            string query = "Select EName from Employee ";
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
            toolStripTextBox1.AutoCompleteCustomSource = coll;
            con.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//searchButton
            SqlConnection con = new SqlConnection(constring);
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
                    String query = ("SELECT EmpID,EName,FatherName,SAddress,CNIC#,Contact#,Speciality,SSubject,Email,PayScale,Salary,Age,BloodGroup,JoinDate,Gender from Employee where EName='" + toolStripTextBox1.Text +  "'");
                    SqlCommand SDA = new SqlCommand(query, con);

                    SqlDataReader data = SDA.ExecuteReader();
                    if (data.Read())
                    {
                        txtRegNumber.Text = data.GetValue(0).ToString();
                        txtName.Text = data.GetValue(1).ToString();
                        txtFatherName.Text = data.GetValue(2).ToString();
                        TxtAddress.Text = data.GetValue(3).ToString();
                        txtcnic.Text = data.GetValue(4).ToString();
                        txtstdContactNumber.Text = data.GetValue(5).ToString();
                        txtSpeciality.Text = data.GetValue(6).ToString();
                        comboboxSubject.Text = data.GetValue(7).ToString();
                        txtEmail.Text = data.GetValue(8).ToString();
                        comboBoxPayScale.Text = data.GetValue(9).ToString();
                        txtSalary.Text = data.GetValue(10).ToString();
                        numericUpDownforAge.Text = data.GetValue(11).ToString();
                        comboboxgender.Text = data.GetValue(12).ToString();
                        DOJpicker.Text = data.GetValue(13).ToString();
                        comboboxgender.Text = data.GetValue(14).ToString();
                        

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
                String query = ("SELECT EmpID from Employee where EName='" + toolStripTextBox1.Text +  "'");
                SqlCommand SDA = new SqlCommand(query, conn);

                SqlDataReader data = SDA.ExecuteReader();
                if (data.Read())
                {
                    PicNumber = Convert.ToInt32(data.GetValue(0).ToString());
                }
                StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\StaffPics\" + PicNumber + ".png");

                conn.Close();
            }
            catch (Exception exp)
            {

            }


        }
        private void StdPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images *.bmp; *.jpg; *.png | *.bmp; *.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAdress = ofd.FileName;
                StdPic.Image = new Bitmap(ofd.FileName);
                gotIMage = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd;
            try
            {
                if (txtRegNumber.Text == "")
                {
                    if (gotIMage == true)
                    {
                        string qr = "insert into Employee values(@name,@fatherName,@Address,@CNIC#,@Contact#,@Speciality,@Subject,@Email,@PayScale,@Salary,@Age,@BloodGroup,@JoinDate,@Gender)";
                        cmd = new SqlCommand(qr, con);
                        if (txtName.Text != "")
                        {

                            cmd.Parameters.AddWithValue("@name", Convert.ToString(txtName.Text));
                            cmd.Parameters.AddWithValue("@fatherName", Convert.ToString(txtFatherName.Text));
                            cmd.Parameters.AddWithValue("@Address", Convert.ToString(TxtAddress.Text));
                            cmd.Parameters.AddWithValue("@Email", Convert.ToString(txtEmail.Text));
                            cmd.Parameters.AddWithValue("@Contact#", Convert.ToString(txtstdContactNumber.Text));
                            cmd.Parameters.AddWithValue("@Speciality", Convert.ToString(txtSpeciality.Text));
                            cmd.Parameters.AddWithValue("@Subject", Convert.ToString(comboboxSubject.Text));
                            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(numericUpDownforAge.Text));
                            cmd.Parameters.AddWithValue("@CNIC#", Convert.ToString(txtcnic.Text));
                            cmd.Parameters.AddWithValue("@PayScale", Convert.ToString(comboBoxPayScale.Text));
                            cmd.Parameters.AddWithValue("@JoinDate", DOJpicker.Value);
                            //cmd.Parameters.AddWithValue("@AdmissionDate", datepickerAdmission.Value);
                            cmd.Parameters.AddWithValue("@BloodGroup", Convert.ToString(comboBoxBloodGroup.Text));
                            cmd.Parameters.AddWithValue("@Gender", Convert.ToString(comboboxgender.Text));
                            cmd.Parameters.AddWithValue("@Salary", Convert.ToString(txtSalary.Text));
                            //cmd.Parameters.AddWithValue("@Scholarship", Convert.ToString(txtScholarship.Text));
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            int EmpID = EmpIdPicker();
                            File.Copy(fileAdress, Path.Combine(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\StaffPics\", ((EmpID + ".png"))), true);
                            string newLine = Environment.NewLine;
                            MessageBox.Show("New Employee: " + txtName.Text + newLine + "have been Registered with  :'" + EmpID + "' EmployeeID Successfully", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxData();

                        }
                        else
                        {
                            MessageBox.Show("Write the employee Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("please upload Employee Picture...!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Please Refresh the page before the Use of this Operation","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(txtRegNumber.Text == String.Empty))
            {
                DialogResult result = MessageBox.Show("Are You Sure, You want to delete This Employee Record", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (!(txtRegNumber.Text == string.Empty))
                    {

                        SqlConnection con = new SqlConnection(constring);
                        string query = "Delete from Employee where EmpID='" + txtRegNumber.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader myreader;
                        try
                        {
                            con.Open();
                            myreader = cmd.ExecuteReader();
                            MessageBox.Show("Successfully Employee Record Deleted", "Information");
                            while (myreader.Read())
                            {
                            }
                            
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
                MessageBox.Show("Please Select A Employee First", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void ClearTextBoxData()
        {
            txtcnic.Clear();
            toolStripTextBox1.Text = "";
            txtFatherName.Clear();
            txtName.Clear();
            comboboxSubject.Text="";
            txtstdContactNumber.Clear();
            txtSalary.Clear();
            TxtAddress.Clear();
            txtRegNumber.Clear();
            comboBoxPayScale.Text = "";
            numericUpDownforAge.Value=20;
            comboBoxBloodGroup.Text="";
            comboboxgender.Text = "";
            txtSpeciality.Text = "";
            txtEmail.Clear();

            StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\StaffPics\alt.png");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd;
            try
            {
                if (txtRegNumber.Text != "")
                {
                    string qr = "UPDATE Employee SET EName= @name ,FatherName=@fatherName,SAddress=@Address,Email=@Email,Contact#=@Student#,Age=@Age,CNIC#=@CNIC#,SSubject=@Subject,JoinDate=@DateofJoin,BloodGroup=@BloodGroup,Gender=@Gender,Speciality=@Speciality,Salary=@Salary,PayScale=@PayScale WHERE EmpID='" + txtRegNumber.Text + "'";
                    cmd = new SqlCommand(qr, con);
                    cmd.Parameters.AddWithValue("@name", Convert.ToString(txtName.Text));
                    cmd.Parameters.AddWithValue("@fatherName", Convert.ToString(txtFatherName.Text));
                    cmd.Parameters.AddWithValue("@Address", Convert.ToString(TxtAddress.Text));
                    cmd.Parameters.AddWithValue("@Email", Convert.ToString(txtEmail.Text));
                    cmd.Parameters.AddWithValue("@Student#", Convert.ToString(txtstdContactNumber.Text));
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(numericUpDownforAge.Text));
                    cmd.Parameters.AddWithValue("@CNIC#", Convert.ToString(txtcnic.Text));
                    cmd.Parameters.AddWithValue("@Subject", Convert.ToString(comboboxSubject.Text));
                    cmd.Parameters.AddWithValue("@DateofJoin", DOJpicker.Value);
                    cmd.Parameters.AddWithValue("@BloodGroup", Convert.ToString(comboBoxBloodGroup.Text));
                    cmd.Parameters.AddWithValue("@Gender", Convert.ToString(comboboxgender.Text));
                    cmd.Parameters.AddWithValue("@Speciality", Convert.ToString(txtSpeciality.Text));
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToString(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@PayScale", Convert.ToString(comboBoxPayScale.Text));
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data is Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select a Employee First ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public int EmpIdPicker()
        {//its gets Rollnumber that is inserted in last
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            int n = 0;
            try
            {
                String query = "SELECT top 1 * FROM Employee order by EmpID Desc;";
                SqlCommand SDA = new SqlCommand(query, conn);

                SqlDataReader data = SDA.ExecuteReader();
                if (data.Read())
                {
                    n = Convert.ToInt32(data.GetValue(0).ToString());
                }
                conn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("EmpId display error :");
            }

            return n;


        }

        private void toolStripBtnRefresh_Click(object sender, EventArgs e)
        {
            ClearTextBoxData();
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
