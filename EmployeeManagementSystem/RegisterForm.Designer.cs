namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            signupbtn = new Button();
            signup_showpassword = new CheckBox();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            Panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signin_loginbtn = new Button();
            label5 = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.FromArgb(33, 11, 97);
            signupbtn.Cursor = Cursors.Hand;
            signupbtn.FlatAppearance.BorderSize = 0;
            signupbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            signupbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            signupbtn.FlatStyle = FlatStyle.Flat;
            signupbtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = Color.White;
            signupbtn.Location = new Point(286, 266);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(84, 33);
            signupbtn.TabIndex = 17;
            signupbtn.Text = "SIGN UP";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // signup_showpassword
            // 
            signup_showpassword.AutoSize = true;
            signup_showpassword.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showpassword.Location = new Point(439, 273);
            signup_showpassword.Name = "signup_showpassword";
            signup_showpassword.Size = new Size(112, 18);
            signup_showpassword.TabIndex = 16;
            signup_showpassword.Text = "Show Password";
            signup_showpassword.UseVisualStyleBackColor = true;
            signup_showpassword.CheckedChanged += signup_showpassword_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_password.Location = new Point(286, 210);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(278, 33);
            signup_password.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(286, 188);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_username.Location = new Point(286, 141);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(278, 33);
            signup_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 119);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(285, 28);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(534, 10);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(33, 11, 97);
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(pictureBox1);
            Panel1.Controls.Add(label6);
            Panel1.Controls.Add(signin_loginbtn);
            Panel1.Controls.Add(label5);
            Panel1.Dock = DockStyle.Left;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(270, 416);
            Panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 187);
            label6.Name = "label6";
            label6.Size = new Size(229, 19);
            label6.TabIndex = 2;
            label6.Text = "Employee Management System";
            // 
            // signin_loginbtn
            // 
            signin_loginbtn.BackColor = Color.FromArgb(0, 0, 64);
            signin_loginbtn.Cursor = Cursors.Hand;
            signin_loginbtn.FlatAppearance.BorderSize = 0;
            signin_loginbtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            signin_loginbtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            signin_loginbtn.FlatStyle = FlatStyle.Flat;
            signin_loginbtn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signin_loginbtn.ForeColor = Color.White;
            signin_loginbtn.Location = new Point(21, 362);
            signin_loginbtn.Name = "signin_loginbtn";
            signin_loginbtn.Size = new Size(226, 42);
            signin_loginbtn.TabIndex = 1;
            signin_loginbtn.Text = "SIGN IN";
            signin_loginbtn.UseVisualStyleBackColor = false;
            signin_loginbtn.Click += signin_loginbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 326);
            label5.Name = "label5";
            label5.Size = new Size(131, 18);
            label5.TabIndex = 0;
            label5.Text = "Login your account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 416);
            Controls.Add(signupbtn);
            Controls.Add(signup_showpassword);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(Panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signupbtn;
        private CheckBox signup_showpassword;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_username;
        private Label label3;
        private Label label2;
        private Label exit;
        private Panel Panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button signin_loginbtn;
        private Label label5;
    }
}