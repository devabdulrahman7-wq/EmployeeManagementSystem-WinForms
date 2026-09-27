namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            statuslbl = new Label();
            phonetxt = new TextBox();
            positiontxt = new ComboBox();
            addbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            clearbtn = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            statustxt = new ComboBox();
            fullnametxt = new TextBox();
            gendertxt = new ComboBox();
            empidtxt = new TextBox();
            positionlbl = new Label();
            label5 = new Label();
            label4 = new Label();
            fullnamelabel = new Label();
            empidlbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 240);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(821, 240);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 16);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.Controls.Add(statuslbl);
            panel2.Controls.Add(phonetxt);
            panel2.Controls.Add(positiontxt);
            panel2.Controls.Add(addbtn);
            panel2.Controls.Add(updatebtn);
            panel2.Controls.Add(deletebtn);
            panel2.Controls.Add(clearbtn);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(statustxt);
            panel2.Controls.Add(fullnametxt);
            panel2.Controls.Add(gendertxt);
            panel2.Controls.Add(empidtxt);
            panel2.Controls.Add(positionlbl);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(fullnamelabel);
            panel2.Controls.Add(empidlbl);
            panel2.Location = new Point(3, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(821, 227);
            panel2.TabIndex = 1;
            // 
            // statuslbl
            // 
            statuslbl.AutoSize = true;
            statuslbl.Font = new Font("Tahoma", 11.25F);
            statuslbl.Location = new Point(390, 103);
            statuslbl.Name = "statuslbl";
            statuslbl.Size = new Size(49, 18);
            statuslbl.TabIndex = 18;
            statuslbl.Text = "Status";
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(471, 26);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(121, 23);
            phonetxt.TabIndex = 17;
            // 
            // positiontxt
            // 
            positiontxt.FormattingEnabled = true;
            positiontxt.Items.AddRange(new object[] { "Data Administration", "Back End Develpor", "Front End Develpor", "Business Management" });
            positiontxt.Location = new Point(471, 64);
            positiontxt.Name = "positiontxt";
            positiontxt.Size = new Size(121, 23);
            positiontxt.TabIndex = 16;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(33, 11, 97);
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            addbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            addbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Tahoma", 11.25F);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(155, 163);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(72, 38);
            addbtn.TabIndex = 15;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(33, 11, 97);
            updatebtn.FlatAppearance.BorderSize = 0;
            updatebtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            updatebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            updatebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Tahoma", 11.25F);
            updatebtn.ForeColor = Color.White;
            updatebtn.Location = new Point(242, 163);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(72, 38);
            updatebtn.TabIndex = 14;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.FromArgb(33, 11, 97);
            deletebtn.FlatAppearance.BorderSize = 0;
            deletebtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            deletebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            deletebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Tahoma", 11.25F);
            deletebtn.ForeColor = Color.White;
            deletebtn.Location = new Point(330, 163);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(72, 38);
            deletebtn.TabIndex = 13;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.FromArgb(33, 11, 97);
            clearbtn.FlatAppearance.BorderSize = 0;
            clearbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 11, 97);
            clearbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            clearbtn.FlatStyle = FlatStyle.Flat;
            clearbtn.Font = new Font("Tahoma", 11.25F);
            clearbtn.ForeColor = Color.White;
            clearbtn.Location = new Point(420, 163);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(72, 38);
            clearbtn.TabIndex = 12;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(690, 154);
            button1.Name = "button1";
            button1.Size = new Size(83, 38);
            button1.TabIndex = 11;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Location = new Point(646, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 145);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // statustxt
            // 
            statustxt.FormattingEnabled = true;
            statustxt.Items.AddRange(new object[] { "Active ", "Inactive" });
            statustxt.Location = new Point(471, 98);
            statustxt.Name = "statustxt";
            statustxt.Size = new Size(121, 23);
            statustxt.TabIndex = 9;
            // 
            // fullnametxt
            // 
            fullnametxt.Location = new Point(170, 64);
            fullnametxt.Name = "fullnametxt";
            fullnametxt.Size = new Size(121, 23);
            fullnametxt.TabIndex = 8;
            // 
            // gendertxt
            // 
            gendertxt.FormattingEnabled = true;
            gendertxt.Items.AddRange(new object[] { "Male", "Female", "Others" });
            gendertxt.Location = new Point(170, 98);
            gendertxt.Name = "gendertxt";
            gendertxt.Size = new Size(121, 23);
            gendertxt.TabIndex = 6;
            // 
            // empidtxt
            // 
            empidtxt.Location = new Point(170, 26);
            empidtxt.Name = "empidtxt";
            empidtxt.Size = new Size(121, 23);
            empidtxt.TabIndex = 5;
            // 
            // positionlbl
            // 
            positionlbl.AutoSize = true;
            positionlbl.Font = new Font("Tahoma", 11.25F);
            positionlbl.Location = new Point(383, 69);
            positionlbl.Name = "positionlbl";
            positionlbl.Size = new Size(56, 18);
            positionlbl.TabIndex = 4;
            positionlbl.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F);
            label5.Location = new Point(54, 103);
            label5.Name = "label5";
            label5.Size = new Size(55, 18);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(383, 31);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 2;
            label4.Text = "Phone no";
            // 
            // fullnamelabel
            // 
            fullnamelabel.AutoSize = true;
            fullnamelabel.Font = new Font("Tahoma", 11.25F);
            fullnamelabel.Location = new Point(54, 69);
            fullnamelabel.Name = "fullnamelabel";
            fullnamelabel.Size = new Size(72, 18);
            fullnamelabel.TabIndex = 1;
            fullnamelabel.Text = "Full Name";
            fullnamelabel.Click += label3_Click;
            // 
            // empidlbl
            // 
            empidlbl.AutoSize = true;
            empidlbl.Font = new Font("Tahoma", 11.25F);
            empidlbl.Location = new Point(54, 31);
            empidlbl.Name = "empidlbl";
            empidlbl.Size = new Size(92, 18);
            empidlbl.TabIndex = 0;
            empidlbl.Text = "Employee ID";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(827, 479);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private TextBox fullnametxt;
        private ComboBox gendertxt;
        private TextBox empidtxt;
        private Label positionlbl;
        private Label label5;
        private Label label4;
        private Label fullnamelabel;
        private Label empidlbl;
        private Button button1;
        private PictureBox pictureBox1;
        private ComboBox statustxt;
        private Button addbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button clearbtn;
        private Label statuslbl;
        private TextBox phonetxt;
        private ComboBox positiontxt;
    }
}
