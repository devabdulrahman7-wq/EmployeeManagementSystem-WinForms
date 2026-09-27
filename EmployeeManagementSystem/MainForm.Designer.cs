namespace EmployeeManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label2 = new Label();
            Text = new Label();
            panel2 = new Panel();
            label4 = new Label();
            signoutbtn = new Button();
            salarybtn = new Button();
            addemployeebtn = new Button();
            dashboardbtn = new Button();
            greetlbl = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            admindashboarc1 = new Admindashboarc();
            addEmployee1 = new AddEmployee();
            salary1 = new salary1();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Text);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 33);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 11);
            label2.Name = "label2";
            label2.Size = new Size(263, 19);
            label2.TabIndex = 1;
            label2.Text = "Employee Management System";
            // 
            // Text
            // 
            Text.AutoSize = true;
            Text.Cursor = Cursors.Hand;
            Text.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text.ForeColor = Color.White;
            Text.Location = new Point(1057, 8);
            Text.Name = "Text";
            Text.Size = new Size(15, 16);
            Text.TabIndex = 0;
            Text.Tag = "";
            Text.Text = "X";
            Text.Click += Text_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(signoutbtn);
            panel2.Controls.Add(salarybtn);
            panel2.Controls.Add(addemployeebtn);
            panel2.Controls.Add(dashboardbtn);
            panel2.Controls.Add(greetlbl);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 528);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 477);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 6;
            label4.Text = ">>>";
            label4.Click += label4_Click;
            // 
            // signoutbtn
            // 
            signoutbtn.Cursor = Cursors.Hand;
            signoutbtn.FlatAppearance.BorderSize = 0;
            signoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            signoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            signoutbtn.FlatStyle = FlatStyle.Flat;
            signoutbtn.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signoutbtn.ForeColor = Color.White;
            signoutbtn.Location = new Point(76, 467);
            signoutbtn.Name = "signoutbtn";
            signoutbtn.Size = new Size(112, 35);
            signoutbtn.TabIndex = 5;
            signoutbtn.Text = "Sign Out";
            signoutbtn.UseVisualStyleBackColor = true;
            signoutbtn.Click += signoutbtn_Click;
            // 
            // salarybtn
            // 
            salarybtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            salarybtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            salarybtn.FlatStyle = FlatStyle.Flat;
            salarybtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            salarybtn.ForeColor = Color.White;
            salarybtn.ImageAlign = ContentAlignment.MiddleLeft;
            salarybtn.Location = new Point(12, 319);
            salarybtn.Name = "salarybtn";
            salarybtn.Size = new Size(200, 40);
            salarybtn.TabIndex = 4;
            salarybtn.Text = "Salary";
            salarybtn.UseVisualStyleBackColor = true;
            salarybtn.Click += salarybtn_Click;
            // 
            // addemployeebtn
            // 
            addemployeebtn.AccessibleDescription = "addempbtn";
            addemployeebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addemployeebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addemployeebtn.FlatStyle = FlatStyle.Flat;
            addemployeebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            addemployeebtn.ForeColor = Color.White;
            addemployeebtn.ImageAlign = ContentAlignment.MiddleLeft;
            addemployeebtn.Location = new Point(12, 273);
            addemployeebtn.Name = "addemployeebtn";
            addemployeebtn.Size = new Size(200, 40);
            addemployeebtn.TabIndex = 3;
            addemployeebtn.Text = "Add Employee";
            addemployeebtn.UseVisualStyleBackColor = true;
            addemployeebtn.Click += button2_Click;
            // 
            // dashboardbtn
            // 
            dashboardbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            dashboardbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            dashboardbtn.FlatStyle = FlatStyle.Flat;
            dashboardbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            dashboardbtn.ForeColor = Color.White;
            dashboardbtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardbtn.Location = new Point(14, 227);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(200, 40);
            dashboardbtn.TabIndex = 2;
            dashboardbtn.Text = "DashBoard";
            dashboardbtn.UseVisualStyleBackColor = true;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // greetlbl
            // 
            greetlbl.AutoSize = true;
            greetlbl.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greetlbl.ForeColor = Color.Transparent;
            greetlbl.Location = new Point(36, 170);
            greetlbl.Name = "greetlbl";
            greetlbl.Size = new Size(152, 22);
            greetlbl.TabIndex = 1;
            greetlbl.Text = "Welcome _User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(admindashboarc1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(salary1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(859, 528);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // admindashboarc1
            // 
            admindashboarc1.Location = new Point(6, 6);
            admindashboarc1.Name = "admindashboarc1";
            admindashboarc1.Size = new Size(787, 470);
            admindashboarc1.TabIndex = 2;
            admindashboarc1.Load += admindashboarc1_Load;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(3, 8);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(827, 479);
            addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.Location = new Point(3, 3);
            salary1.Name = "salary1";
            salary1.Size = new Size(822, 475);
            salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label greetlbl;
        private PictureBox pictureBox1;
        private Button salarybtn;
        private Button addemployeebtn;
        private Button dashboardbtn;
        private Button signoutbtn;
        private Label label4;
        private Label Text;
        private Panel panel3;
        private salary1 salary2;
        private salary1 salaryboard;
        private AddEmployee addEmployee1;
        private salary1 salary1;
        private Admindashboarc admindashboarc1;
    }
}