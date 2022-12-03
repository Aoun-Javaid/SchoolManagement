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
    public partial class Admission : Sample
    {
        public string UName;
        public Admission(string name)
        {
            InitializeComponent();
            this.UName = name;
        }
        public string fileAdress;
        Boolean gotIMage = false;
        public string constring = "Data Source=DESKTOP-1K7RKPF\\SQLEXPRESS;Initial Catalog=SMdemodb;Integrated Security=True";
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {//fro image

                if (gotIMage == true)
                {


                    SqlCommand cmd;

                    string s = "insert into Students values(@name,@fatherName,@Address,@Email,@Student#,@RefName,@Guardian#,@Age,@CNIC#,@Class,@DOB,@BloodGroup,@Gender,@Transport,@Scholarship,@AdmissionDate)";
                    cmd = new SqlCommand(s, con);
                    if (txtName.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@name", Convert.ToString(txtName.Text));
                        if (txtFatherName.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@fatherName", Convert.ToString(txtFatherName.Text));
                            if (TxtAddress.Text != "")
                            {
                                cmd.Parameters.AddWithValue("@Address", Convert.ToString(TxtAddress.Text));
                                cmd.Parameters.AddWithValue("@Email", Convert.ToString(txtEmail.Text));
                                if (txtstdContactNumber.Text != "")
                                {
                                    cmd.Parameters.AddWithValue("@Student#", Convert.ToString(txtstdContactNumber.Text));
                                    cmd.Parameters.AddWithValue("@RefName", Convert.ToString(txtReferenceNumber.Text));
                                    if (txtFatherMobileNumber.Text != "")
                                    {
                                        cmd.Parameters.AddWithValue("@Guardian#", Convert.ToString(txtFatherMobileNumber.Text));
                                        cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(numericUpDownforAge.Value));
                                        if (txtcnic.Text != "")
                                        {
                                            cmd.Parameters.AddWithValue("@CNIC#", Convert.ToString(txtcnic.Text));
                                            if (comboboxClass.Text != "")
                                            {
                                                cmd.Parameters.AddWithValue("@Class", Convert.ToString(comboboxClass.Text));
                                                cmd.Parameters.AddWithValue("@DOB", DOBpicker.Value);
                                                cmd.Parameters.AddWithValue("@AdmissionDate", datepickerAdmission.Value);
                                                if (comboBox2.Text != "")
                                                {
                                                    cmd.Parameters.AddWithValue("@BloodGroup", Convert.ToString(comboBox2.Text));
                                                    if (comboboxgender.Text != "")
                                                    {
                                                        cmd.Parameters.AddWithValue("@Gender", Convert.ToString(comboboxgender.Text));
                                                        cmd.Parameters.AddWithValue("@Transport", Convert.ToString(txtTransport.Text));
                                                        int scholarship = 0;
                                                        if (rdo100kindship.Checked == true)
                                                        {
                                                            scholarship = 100;
                                                        }
                                                        else if (rdo75Hardship.Checked == true)
                                                        {
                                                            scholarship = 75;
                                                        }
                                                        else if (rdo50loyality.Checked == true)
                                                        {
                                                            scholarship = 50;
                                                        }
                                                        else if (rdo25Relation.Checked == true)
                                                        {
                                                            scholarship = 25;
                                                        }
                                                        else
                                                        {
                                                            scholarship = 0;
                                                        }
                                                        cmd.Parameters.AddWithValue("@Scholarship", scholarship);


                                                        cmd.CommandType = CommandType.Text;
                                                        cmd.ExecuteNonQuery();
                                                        int Regnumber = RollNumberPicker();
                                                        File.Copy(fileAdress, Path.Combine(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\Images\", ((Regnumber + ".png"))), true);
                                                        // MessageBox.Show("Student is  ");

                                                        string newLine = Environment.NewLine;
                                                        MessageBox.Show("New Student: " + txtName.Text + newLine + "have been Registered with  :'" + Regnumber + "' RollNumber Successfully", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        ClearTextBoxData();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Select the gender of the Student", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Select BloodGroup of the Student", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Select Class of the Student", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Write the CNIC/B-Form Number of Student", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Write the Parent/Guardian Contact Number", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Write the Student Contact NUmber", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Write Address of the Student", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Write the father name", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Write Student Name", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload a Picture", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
        }
        public int RollNumberPicker()
        {//its gets Rollnumber that is inserted in last
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            int n = 0;
            try
            {
                String query = "SELECT top 1 * FROM Students order by RegNumber Desc;";
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
                MessageBox.Show("RollNumber display error :");
            }

            return n;


        }
        public void ClearTextBoxData()
        {
            txtcnic.Clear();
            txtFatherMobileNumber.Clear();
            txtFatherName.Clear();
            txtName.Clear();
            txtReferenceNumber.Clear();
            txtstdContactNumber.Clear();
            txtTransport.Clear();
            TxtAddress.Clear();
            
            StdPic.Image = Image.FromFile(@"C:\Users\Chairman NAB\source\repos\AssignmentVpSMS\AssignmentVpSMS\Images\alt.png");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //fileAdress = StdPic;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images *.bmp; *.jpg; *.png | *.bmp; *.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAdress = ofd.FileName;
                StdPic.Image = new Bitmap(ofd.FileName);
                gotIMage = true;
            }
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
