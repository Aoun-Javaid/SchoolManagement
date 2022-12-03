namespace AssignmentVpSMS
{
    partial class Finance
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
            this.btnExpenditures = new System.Windows.Forms.Button();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.btnFees = new System.Windows.Forms.Button();
            this.btnDefaulters = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.LPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RPanel
            // 
            this.RPanel.Size = new System.Drawing.Size(233, 450);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Size = new System.Drawing.Size(233, 410);
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
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnExpenditures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalaries, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDefaulters, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExpenditures
            // 
            this.btnExpenditures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpenditures.FlatAppearance.BorderSize = 3;
            this.btnExpenditures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenditures.Location = new System.Drawing.Point(3, 134);
            this.btnExpenditures.Name = "btnExpenditures";
            this.btnExpenditures.Size = new System.Drawing.Size(183, 125);
            this.btnExpenditures.TabIndex = 4;
            this.btnExpenditures.Text = "Expenditures";
            this.btnExpenditures.UseVisualStyleBackColor = true;
            // 
            // btnSalaries
            // 
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalaries.FlatAppearance.BorderSize = 3;
            this.btnSalaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaries.Location = new System.Drawing.Point(381, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(183, 125);
            this.btnSalaries.TabIndex = 2;
            this.btnSalaries.Text = "Salaries";
            this.btnSalaries.UseVisualStyleBackColor = true;
            // 
            // btnFees
            // 
            this.btnFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFees.FlatAppearance.BorderSize = 3;
            this.btnFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFees.Location = new System.Drawing.Point(192, 3);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(183, 125);
            this.btnFees.TabIndex = 1;
            this.btnFees.Text = "Fees";
            this.btnFees.UseVisualStyleBackColor = true;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // btnDefaulters
            // 
            this.btnDefaulters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefaulters.FlatAppearance.BorderSize = 3;
            this.btnDefaulters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaulters.Location = new System.Drawing.Point(3, 3);
            this.btnDefaulters.Name = "btnDefaulters";
            this.btnDefaulters.Size = new System.Drawing.Size(183, 125);
            this.btnDefaulters.TabIndex = 0;
            this.btnDefaulters.Text = "Defaulters";
            this.btnDefaulters.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(192, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 125);
            this.button1.TabIndex = 5;
            this.button1.Text = "Profit/Loss";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AssignmentVpSMS.Properties.Resources.money_icon;
            this.pictureBox1.Location = new System.Drawing.Point(42, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Finance";
            this.Text = "Finance";
            this.RPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.LPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button btnDefaulters;
        private System.Windows.Forms.Button btnExpenditures;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}