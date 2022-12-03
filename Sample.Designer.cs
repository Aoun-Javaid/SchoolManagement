namespace AssignmentVpSMS
{
    partial class Sample
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
            this.RPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.RPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.LPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RPanel
            // 
            this.RPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RPanel.Controls.Add(this.panel5);
            this.RPanel.Controls.Add(this.panel4);
            this.RPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RPanel.Location = new System.Drawing.Point(0, 0);
            this.RPanel.Name = "RPanel";
            this.RPanel.Size = new System.Drawing.Size(233, 485);
            this.RPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 445);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 40);
            this.panel4.TabIndex = 0;
            // 
            // LPanel
            // 
            this.LPanel.Controls.Add(this.panel6);
            this.LPanel.Controls.Add(this.panel3);
            this.LPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LPanel.Location = new System.Drawing.Point(233, 0);
            this.LPanel.Name = "LPanel";
            this.LPanel.Size = new System.Drawing.Size(700, 485);
            this.LPanel.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 428);
            this.panel6.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 57);
            this.panel3.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::AssignmentVpSMS.Properties.Resources.Rafiqul_Hassan_Blogger_Arrow_Back;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.ControlBox = false;
            this.Controls.Add(this.LPanel);
            this.Controls.Add(this.RPanel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Sample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.RPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.LPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel RPanel;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel LPanel;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnBack;
    }
}