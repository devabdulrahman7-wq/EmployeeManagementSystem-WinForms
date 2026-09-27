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
    public partial class salary1 : UserControl
    {
        public salary1()
        {

            InitializeComponent();
            LoadGrid();
            disableFields();

        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayemployees();
            disableFields();
        }
        public void disableFields()
        {
            //    empidtxt.Enabled = false;
            //    fullnametxt.Enabled = false;
            //    positiontxt.Enabled = false;
        }
        private void LoadGrid()
        {
            string connStr = "server=localhost;user id=root;password=;database=employee;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT `employee_id`, `full_name`, `gender`, `contact_no`, `position`, `salary` FROM `employeeinfo` WHERE status = 'Active' AND delete_date IS NULL";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void displayemployees()
        {
            //   SalaryData ed = new SalaryData();
            //    List<SalaryData> listdata = ed.salaryEmployeeListData();
            //    dataGridView1.DataSource = listdata;
        }


        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (empidtxt.Text == ""
                || fullnametxt.Text == ""
                || positiontxt.Text == ""
                || salarytxt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: "
                    + empidtxt.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    string connstring = "server=localhost;user id=root;password=;database=employee";
                    MySqlConnection connect = new MySqlConnection(connstring);
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE `employeeinfo` SET `salary` = @salary,`update_date` =@updatedate WHERE employee_id = @employeeID";

                            using (MySqlCommand cmd = new MySqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salarytxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@updatedate", today);
                                cmd.Parameters.AddWithValue("@employeeID", empidtxt.Text.Trim());
                                cmd.ExecuteNonQuery();
                                displayemployees();
                                MessageBox.Show("Updated successfully!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadGrid();
        }
        public void clearFields()
        {
            empidtxt.Text = "";
            fullnametxt.Text = "";
            positiontxt.Text = "";
            salarytxt.Text = "";
        }
        //private void clearbtn_Click(object sender, EventArgs e)
        //{

        //}
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            clearFields();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void positiontxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                empidtxt.Text = row.Cells[0].Value.ToString();
                fullnametxt.Text = row.Cells[1].Value.ToString();
                positiontxt.Text = row.Cells[4].Value.ToString();
                salarytxt.Text = row.Cells[5].Value.ToString();
            }
        }
    }


}
