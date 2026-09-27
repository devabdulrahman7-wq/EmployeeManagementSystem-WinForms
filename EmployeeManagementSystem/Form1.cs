using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signup_Click(object sender, EventArgs e)
        {

            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
        private void regitrationform_Load(object sender, EventArgs e)
        {
        }
        private void registrationform_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void logiinbtn_Click(object sender, EventArgs e)
        {
            string Connstring = "server=localhost;user id=root;password=;database=employee";
            MySqlConnection conn = new MySqlConnection(Connstring);
            if (login_username.Text == ""
                || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blanks fields", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                    try
                    {
                        conn.Open();
                        string query = "SELECT *FROM `employee`WHERE username=@username AND password=@password";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)

                            {
                                MessageBox.Show("Login successfully", "Information Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm form = new MainForm();
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username/password", "Error Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();

                    }
            }
        }



        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {

            login_password.PasswordChar = login_showpassword.Checked ? '\0' : '*';
        }
    }
}
