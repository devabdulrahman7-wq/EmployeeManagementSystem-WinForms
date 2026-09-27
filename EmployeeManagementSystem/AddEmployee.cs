using Microsoft.VisualBasic.Devices;
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
    public partial class AddEmployee : UserControl
    {

        string connstring = "server=localhost;user id=root;password=;database=employee";

        public AddEmployee()

        {
            // for dispaly data from database to grid
            InitializeComponent();
            displayEmployeesData();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeesData();
        }
        public void displayEmployeesData()
        {
            EmployeesData ed = new EmployeesData();
            List<EmployeesData> listdata = ed.employeesListData();
            // dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listdata;


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(empidtxt.Text) ||
                string.IsNullOrWhiteSpace(fullnametxt.Text) ||
                string.IsNullOrWhiteSpace(gendertxt.Text) ||
                string.IsNullOrWhiteSpace(positiontxt.Text) ||
                string.IsNullOrWhiteSpace(phonetxt.Text) ||
                string.IsNullOrWhiteSpace(statustxt.Text) ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    conn.Open();


                    string checkQuery = "SELECT COUNT(*) FROM `employeeinfo` WHERE employee_id = @empID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@empID", empidtxt.Text.Trim());
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show($"{empidtxt.Text.Trim()} is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    DateTime today = DateTime.Today;

                    string directoryPath = @"C:\Downloads";
                    if (!System.IO.Directory.Exists(directoryPath))
                    {
                        System.IO.Directory.CreateDirectory(directoryPath);
                    }
                    string imagePath = System.IO.Path.Combine(directoryPath, empidtxt.Text.Trim() + ".jpg");
                    pictureBox1.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    string insertQuery = @"
                INSERT INTO `employeeinfo`
                (`employee_id`, `full_name`, `gender`, `contact_no`, `salary`, `position`, `image`, `status`, `insert_date`)
                VALUES
                (@employeeid, @fullname, @gender, @contactno, @salary, @position, @image, @status, @insertdate)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeid", empidtxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@fullname", fullnametxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", gendertxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactno", phonetxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@salary", 0);
                        cmd.Parameters.AddWithValue("@position", positiontxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@image", imagePath);
                        cmd.Parameters.AddWithValue("@status", statustxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@insertdate",today);
                      //  cmd.Parameters.AddWithValue("@updatedate", now);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayEmployeesData();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadGrid();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg, .png,*.icon)|*.jpg,.png,*.icon";
            string imagepath = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = dialog.FileName;
                pictureBox1.ImageLocation = imagepath;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                empidtxt.Text = row.Cells[1].Value.ToString();
                fullnametxt.Text = row.Cells[2].Value.ToString();
                gendertxt.Text = row.Cells[3].Value.ToString();
                phonetxt.Text = row.Cells[4].Value.ToString();
                positiontxt.Text = row.Cells[5].Value.ToString();
                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                }

                statustxt.Text = row.Cells[8].Value.ToString();
            }
        }
        public void clearFields()
        {
            empidtxt.Text = "";
            fullnametxt.Text = "";
            gendertxt.SelectedIndex = -1;
            phonetxt.Text = "";
            positiontxt.SelectedIndex = -1;
            statustxt.SelectedIndex = -1;
            pictureBox1.Image = null;
        }
        private void LoadGrid()
        {
            string connStr = "server=localhost;user id=root;password=;database=employee;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM employeeinfo";
                   // string query = "SELECT `employee_id`, `full_name`, `gender`, `contact_no`, `position`, `salary` FROM `employeeinfo` WHERE status = 'Active' delete_date IS NULL";
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
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (empidtxt.Text == "" || fullnametxt.Text == "" || gendertxt.Text == "" ||
                phonetxt.Text == "" || positiontxt.Text == "" || statustxt.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: " + empidtxt.Text.Trim() + "?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (check == DialogResult.Yes)
            {
                try
                {
                    DateTime today = DateTime.Today;
                    string updateQuery = "UPDATE `employeeinfo` SET  `full_name` = @fullname, `gender` = @gender,`contact_no` = @contact,`position` = @position, `update_date` = @updateDate, `status` = @status WHERE employee_id = @employeeID";
                    using (MySqlConnection connect = new MySqlConnection(connstring))
                    {
                        connect.Open();

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname", fullnametxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", gendertxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", phonetxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", positiontxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", statustxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", empidtxt.Text.Trim());
                            cmd.ExecuteNonQuery();
                            LoadGrid();
                        }
                    }
                    displayEmployeesData();

                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["employee_id"].Value);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this employee?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    string connStr = "server=localhost;user id=root;password=;database=employee;";
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string query = "DELETE FROM `employeeinfo` WHERE employee_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Employee Deleted Successfully ");
                            LoadGrid();

                        }
                        else
                        {
                            MessageBox.Show("Delete Failed ");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete!");
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
            LoadGrid();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



