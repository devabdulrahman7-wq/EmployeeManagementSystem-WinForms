namespace EmployeeManagementSystem
{
    partial class Admindashboarc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            addEmployee1 = new AddEmployee();
            panel4 = new Panel();
            label5 = new Label();
            dashboard_IE = new Label();
            panel5 = new Panel();
            label2 = new Label();
            dashboard_TE = new Label();
            panel3 = new Panel();
            label3 = new Label();
            dashboard_AE = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(addEmployee1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 178);
            panel1.TabIndex = 1;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(770, 30);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(827, 479);
            addEmployee1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(75, 8, 138);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(dashboard_IE);
            panel4.Location = new Point(529, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 138);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(66, 80);
            label5.Name = "label5";
            label5.Size = new Size(135, 18);
            label5.TabIndex = 3;
            label5.Text = "Inactive Employees";
            // 
            // dashboard_IE
            // 
            dashboard_IE.AutoSize = true;
            dashboard_IE.Font = new Font("Tahoma", 9.75F);
            dashboard_IE.ForeColor = Color.White;
            dashboard_IE.Location = new Point(187, 18);
            dashboard_IE.Name = "dashboard_IE";
            dashboard_IE.Size = new Size(14, 16);
            dashboard_IE.TabIndex = 2;
            dashboard_IE.Text = "0";
            dashboard_IE.Click += dashboard_IE_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(75, 8, 138);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dashboard_TE);
            panel5.ForeColor = Color.CornflowerBlue;
            panel5.Location = new Point(20, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(211, 138);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 18);
            label2.TabIndex = 1;
            label2.Text = "Total Employees";
            // 
            // dashboard_TE
            // 
            dashboard_TE.AutoSize = true;
            dashboard_TE.Font = new Font("Tahoma", 9.75F);
            dashboard_TE.ForeColor = Color.White;
            dashboard_TE.Location = new Point(175, 18);
            dashboard_TE.Name = "dashboard_TE";
            dashboard_TE.Size = new Size(14, 16);
            dashboard_TE.TabIndex = 0;
            dashboard_TE.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(75, 8, 138);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dashboard_AE);
            panel3.Location = new Point(265, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 138);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 80);
            label3.Name = "label3";
            label3.Size = new Size(122, 18);
            label3.TabIndex = 3;
            label3.Text = "Active Employees";
            // 
            // dashboard_AE
            // 
            dashboard_AE.AutoSize = true;
            dashboard_AE.Font = new Font("Tahoma", 9.75F);
            dashboard_AE.ForeColor = Color.White;
            dashboard_AE.Location = new Point(183, 18);
            dashboard_AE.Name = "dashboard_AE";
            dashboard_AE.Size = new Size(14, 16);
            dashboard_AE.TabIndex = 2;
            dashboard_AE.Text = "0";
            // 
            // Admindashboarc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Admindashboarc";
            Size = new Size(787, 470);
            Load += Admindashboarc_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private AddEmployee addEmployee1;
        private Panel panel4;
        private Label label5;
        private Label dashboard_IE;
        private Panel panel5;
        private Label label2;
        private Label dashboard_TE;
        private Panel panel3;
        private Label label3;
        private Label dashboard_AE;
    }
}
