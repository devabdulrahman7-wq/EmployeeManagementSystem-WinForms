using EmployeeManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace EmployeeManagementSystem
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
            displayTE();
            displayAE();
            displayIE();
        }


        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayTE();
            displayAE();
            displayIE();
        }

        public void displayTE()
        {
            string connstring = "server=localhost;user id=root;password=;database=employeesinfo";
            MySqlConnection connect = new MySqlConnection(connstring);
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TE.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayAE()
        {
            string connstring = "server=localhost;user id=root;password=;database=employeesinfo";
            MySqlConnection connect = new MySqlConnection(connstring);
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status " +
                        "AND delete_date IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AE.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayIE()
        {
            string connstring = "server=localhost;user id=root;password=;database=employeesinfo";
            MySqlConnection connect = new MySqlConnection(connstring);
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status " +
                        "AND delete_date IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Ianctive");
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IE.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_IE_Click(object sender, EventArgs e)
        {

        }

        private void dashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}


