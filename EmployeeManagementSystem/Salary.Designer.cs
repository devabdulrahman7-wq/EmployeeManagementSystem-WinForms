namespace EmployeeManagementSystem
{
    partial class salary1
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
            clearbtn = new Button();
            updatebtn = new Button();
            fullnametxt = new TextBox();
            salarytxt = new TextBox();
            positiontxt = new TextBox();
            empidtxt = new TextBox();
            salarylbl = new Label();
            positionlbl = new Label();
            fullnamelbl = new Label();
            empidlbl = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(clearbtn);
            panel1.Controls.Add(updatebtn);
            panel1.Controls.Add(fullnametxt);
            panel1.Controls.Add(salarytxt);
            panel1.Controls.Add(positiontxt);
            panel1.Controls.Add(empidtxt);
            panel1.Controls.Add(salarylbl);
            panel1.Controls.Add(positionlbl);
            panel1.Controls.Add(fullnamelbl);
            panel1.Controls.Add(empidlbl);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 469);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.FromArgb(33, 11, 97);
            clearbtn.FlatAppearance.BorderSize = 0;
            clearbtn.FlatStyle = FlatStyle.Flat;
            clearbtn.Font = new Font("Tahoma", 11.25F);
            clearbtn.ForeColor = Color.White;
            clearbtn.Location = new Point(97, 314);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(90, 35);
            clearbtn.TabIndex = 10;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click_1;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(33, 11, 97);
            updatebtn.FlatAppearance.BorderSize = 0;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Tahoma", 11.25F);
            updatebtn.ForeColor = Color.White;
            updatebtn.Location = new Point(97, 254);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(90, 35);
            updatebtn.TabIndex = 9;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // fullnametxt
            // 
            fullnametxt.Font = new Font("Segoe UI", 9.75F);
            fullnametxt.Location = new Point(118, 100);
            fullnametxt.Name = "fullnametxt";
            fullnametxt.Size = new Size(137, 25);
            fullnametxt.TabIndex = 7;
            // 
            // salarytxt
            // 
            salarytxt.Font = new Font("Segoe UI", 9.75F);
            salarytxt.Location = new Point(118, 146);
            salarytxt.Name = "salarytxt";
            salarytxt.Size = new Size(137, 25);
            salarytxt.TabIndex = 6;
            // 
            // positiontxt
            // 
            positiontxt.Font = new Font("Segoe UI", 9.75F);
            positiontxt.Location = new Point(118, 188);
            positiontxt.Name = "positiontxt";
            positiontxt.Size = new Size(137, 25);
            positiontxt.TabIndex = 5;
            positiontxt.TextChanged += positiontxt_TextChanged;
            // 
            // empidtxt
            // 
            empidtxt.Font = new Font("Segoe UI", 9.75F);
            empidtxt.Location = new Point(118, 54);
            empidtxt.Name = "empidtxt";
            empidtxt.Size = new Size(137, 25);
            empidtxt.TabIndex = 4;
            // 
            // salarylbl
            // 
            salarylbl.AutoSize = true;
            salarylbl.Font = new Font("Tahoma", 11.25F);
            salarylbl.Location = new Point(20, 153);
            salarylbl.Name = "salarylbl";
            salarylbl.Size = new Size(47, 18);
            salarylbl.TabIndex = 3;
            salarylbl.Text = "Salary";
            // 
            // positionlbl
            // 
            positionlbl.AutoSize = true;
            positionlbl.Font = new Font("Tahoma", 11.25F);
            positionlbl.Location = new Point(20, 195);
            positionlbl.Name = "positionlbl";
            positionlbl.Size = new Size(56, 18);
            positionlbl.TabIndex = 2;
            positionlbl.Text = "Position";
            // 
            // fullnamelbl
            // 
            fullnamelbl.AutoSize = true;
            fullnamelbl.Font = new Font("Tahoma", 11.25F);
            fullnamelbl.Location = new Point(20, 107);
            fullnamelbl.Name = "fullnamelbl";
            fullnamelbl.Size = new Size(72, 18);
            fullnamelbl.TabIndex = 1;
            fullnamelbl.Text = "Full Name";
            // 
            // empidlbl
            // 
            empidlbl.AutoSize = true;
            empidlbl.Font = new Font("Tahoma", 11.25F);
            empidlbl.Location = new Point(20, 61);
            empidlbl.Name = "empidlbl";
            empidlbl.Size = new Size(92, 18);
            empidlbl.TabIndex = 0;
            empidlbl.Text = "Employee ID";
            empidlbl.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(326, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 469);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(450, 401);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 16);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // salary1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "salary1";
            Size = new Size(822, 475);
            Load += Salary_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox fullnametxt;
        private TextBox salarytxt;
        private TextBox positiontxt;
        private TextBox empidtxt;
        private Label salarylbl;
        private Label positionlbl;
        private Label fullnamelbl;
        private Label empidlbl;
        private Button button4;
        private Button button3;
        private Button updatebtn;
        private Button button1;
        private Button clearbtn;
    }
}
