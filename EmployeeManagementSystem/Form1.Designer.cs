namespace EmployeeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signup_loginbtn = new Button();
            label5 = new Label();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_showpassword = new CheckBox();
            logiinbtn = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(33, 11, 97);
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(pictureBox1);
            Panel1.Controls.Add(label6);
            Panel1.Controls.Add(signup_loginbtn);
            Panel1.Controls.Add(label5);
            Panel1.Dock = DockStyle.Left;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(270, 400);
            Panel1.TabIndex = 0;
            Panel1.Paint += Panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 165);
            label6.Name = "label6";
            label6.Size = new Size(229, 19);
            label6.TabIndex = 2;
            label6.Text = "Employee Management System";
            // 
            // signup_loginbtn
            // 
            signup_loginbtn.BackColor = Color.FromArgb(0, 0, 64);
            signup_loginbtn.Cursor = Cursors.Hand;
            signup_loginbtn.FlatAppearance.BorderSize = 0;
            signup_loginbtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            signup_loginbtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            signup_loginbtn.FlatStyle = FlatStyle.Flat;
            signup_loginbtn.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_loginbtn.ForeColor = Color.White;
            signup_loginbtn.Location = new Point(21, 338);
            signup_loginbtn.Name = "signup_loginbtn";
            signup_loginbtn.Size = new Size(229, 49);
            signup_loginbtn.TabIndex = 1;
            signup_loginbtn.Text = "SIGNUP";
            signup_loginbtn.UseVisualStyleBackColor = false;
            signup_loginbtn.Click += login_signup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 303);
            label5.Name = "label5";
            label5.Size = new Size(162, 19);
            label5.TabIndex = 0;
            label5.Text = "Register your account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(555, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 25);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 151);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(292, 181);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(261, 25);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(292, 240);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(261, 27);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 209);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_showpassword
            // 
            login_showpassword.AutoSize = true;
            login_showpassword.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpassword.Location = new Point(421, 304);
            login_showpassword.Name = "login_showpassword";
            login_showpassword.Size = new Size(112, 18);
            login_showpassword.TabIndex = 7;
            login_showpassword.Text = "Show Password";
            login_showpassword.UseVisualStyleBackColor = true;
            login_showpassword.CheckedChanged += login_showpassword_CheckedChanged;
            // 
            // logiinbtn
            // 
            logiinbtn.BackColor = Color.FromArgb(33, 11, 97);
            logiinbtn.Cursor = Cursors.Hand;
            logiinbtn.FlatAppearance.BorderSize = 0;
            logiinbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            logiinbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            logiinbtn.FlatStyle = FlatStyle.Flat;
            logiinbtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logiinbtn.ForeColor = Color.White;
            logiinbtn.Location = new Point(288, 284);
            logiinbtn.Name = "logiinbtn";
            logiinbtn.Size = new Size(78, 38);
            logiinbtn.TabIndex = 8;
            logiinbtn.Text = "LOGIN";
            logiinbtn.UseVisualStyleBackColor = false;
            logiinbtn.Click += logiinbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(logiinbtn);
            Controls.Add(login_showpassword);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(Panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private CheckBox login_showpassword;
        private Button logiinbtn;
        private Button signup_loginbtn;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
