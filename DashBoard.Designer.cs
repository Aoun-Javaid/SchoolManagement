namespace AssignmentVpSMS
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnTimeTables = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTagUSername = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.LPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RPanel
            // 
            this.RPanel.Size = new System.Drawing.Size(233, 450);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Size = new System.Drawing.Size(233, 410);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblUName);
            this.panel4.Controls.Add(this.lblTagUSername);
            this.panel4.Controls.SetChildIndex(this.btnBack, 0);
            this.panel4.Controls.SetChildIndex(this.lblTagUSername, 0);
            this.panel4.Controls.SetChildIndex(this.lblUName, 0);
            // 
            // LPanel
            // 
            this.LPanel.Size = new System.Drawing.Size(567, 450);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel1);
            this.panel6.Size = new System.Drawing.Size(567, 393);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(567, 57);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFinance, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGroups, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdmission, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTimeTables, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnResults, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExams, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStaff, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStudents, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.FlatAppearance.BorderSize = 3;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(3, 199);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(135, 92);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinance.FlatAppearance.BorderSize = 3;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinance.Location = new System.Drawing.Point(426, 101);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(138, 92);
            this.btnFinance.TabIndex = 7;
            this.btnFinance.Text = "Finance";
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGroups.FlatAppearance.BorderSize = 3;
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.Location = new System.Drawing.Point(285, 101);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(135, 92);
            this.btnGroups.TabIndex = 6;
            this.btnGroups.Text = "Groups/Houses";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnAdmission
            // 
            this.btnAdmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmission.FlatAppearance.BorderSize = 3;
            this.btnAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmission.Location = new System.Drawing.Point(144, 101);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(135, 92);
            this.btnAdmission.TabIndex = 5;
            this.btnAdmission.Text = "Admissions";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnTimeTables
            // 
            this.btnTimeTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeTables.FlatAppearance.BorderSize = 3;
            this.btnTimeTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeTables.Location = new System.Drawing.Point(3, 101);
            this.btnTimeTables.Name = "btnTimeTables";
            this.btnTimeTables.Size = new System.Drawing.Size(135, 92);
            this.btnTimeTables.TabIndex = 4;
            this.btnTimeTables.Text = "TimeTables";
            this.btnTimeTables.UseVisualStyleBackColor = true;
            this.btnTimeTables.Click += new System.EventHandler(this.btnTimeTables_Click);
            // 
            // btnResults
            // 
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResults.FlatAppearance.BorderSize = 3;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Location = new System.Drawing.Point(426, 3);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(138, 92);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnExams
            // 
            this.btnExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExams.FlatAppearance.BorderSize = 3;
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExams.Location = new System.Drawing.Point(285, 3);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(135, 92);
            this.btnExams.TabIndex = 2;
            this.btnExams.Text = "Exams";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStaff.FlatAppearance.BorderSize = 3;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Location = new System.Drawing.Point(144, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(135, 92);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudents.FlatAppearance.BorderSize = 3;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Location = new System.Drawing.Point(3, 3);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(135, 92);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "School\r\nManagement\r\nSystem ";
            // 
            // lblTagUSername
            // 
            this.lblTagUSername.AutoSize = true;
            this.lblTagUSername.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagUSername.ForeColor = System.Drawing.Color.Black;
            this.lblTagUSername.Location = new System.Drawing.Point(38, 9);
            this.lblTagUSername.Name = "lblTagUSername";
            this.lblTagUSername.Size = new System.Drawing.Size(90, 16);
            this.lblTagUSername.TabIndex = 1;
            this.lblTagUSername.Text = "Welcome,";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Font = new System.Drawing.Font("Harrington", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUName.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblUName.Location = new System.Drawing.Point(114, 23);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(98, 17);
            this.lblUName.TabIndex = 2;
            this.lblUName.Text = "Aoun Javaid";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(144, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 92);
            this.button1.TabIndex = 9;
            this.button1.Text = "Attendance";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.RPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.LPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnTimeTables;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTagUSername;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Button button1;
    }
}