using EmployeeManagementSystem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeManagementSystem
{
    public partial class RegisterForm : Form
    {
        //string Connstring = "server=localhost;user id=root;password=;database=employee"; 

        public RegisterForm()
        {
            InitializeComponent();
        }
        private void signupbtn_Click(object sender, EventArgs e)
        {
            string Connstring = "server=localhost;user id=root;password=;database=employee";

            MySqlConnection connect = new MySqlConnection(Connstring);
            if (signup_username.Text == null
              || signup_password.Text == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectUsername = "SELECT `id` FROM `employee` WHERE username = @user";

                        using (MySqlCommand checkUser = new MySqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            //var count = (int)checkUser.ExecuteScalar();

                            //if (count != null)
                            if (connect.State != ConnectionState.Open)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO `employee`(`username`, `password`, `date_register`)VALUES(@username, @password, @dateReg)";

                                using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void signin_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 regform = new Form1();
            regform.Show();
            this.Hide();
        }
        private void signup_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showpassword.Checked ? '\0' : '*';
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}










