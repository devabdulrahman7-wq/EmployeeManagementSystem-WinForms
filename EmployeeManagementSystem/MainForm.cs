using Mysqlx.Datatypes;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admindashboarc1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;
            AddEmployee empForm = addEmployee1 as AddEmployee;

            if (empForm != null)
            {
                empForm.RefreshData();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Text_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want log out", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            admindashboarc1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            Admindashboarc dashForm = admindashboarc1 as Admindashboarc;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        private void salarybtn_Click(object sender, EventArgs e)
        {
            admindashboarc1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
            salary1 salaryForm = salary1 as salary1;

            if (salaryForm != null)
            {
                //salaryForm.RefreshData();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //DialogResult check = MessageBox.Show("Are you sure you want log out", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (check == DialogResult.Yes)
            //{
            //    Form1 form1 = new Form1();
            //    form1.Show();
            //    this.Hide();
        }

        private void admindashboarc1_Load(object sender, EventArgs e)
        {

        }
    }
}

