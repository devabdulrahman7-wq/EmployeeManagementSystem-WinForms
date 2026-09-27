using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    class SalaryData
    {

        public string EmployeeID { set; get; } // 0
        public string Name { set; get; } // 1
        public string Gender { set; get; } // 2
        public string Contact { set; get; } // 3
        public string Position { set; get; } // 4
        public int Salary { set; get; } // 5

        public List<SalaryData> salaryEmployeeListData()
        {
            string connstring = "server=localhost;user id=root;password=;database=employee";
             string selectData = "SELECT * FROM employeeinfo WHERE status = 'Active' AND delete_date IS NULL";
            MySqlConnection connect = new MySqlConnection(connstring);
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.EmployeeID = reader["employee_id"].ToString();
                            sd.Name = reader["full_name"].ToString();
                            sd.Gender = reader["gender"].ToString();
                            sd.Contact = reader["contact_number"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Salary = (int)reader["salary"];

                            listdata.Add(sd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

    }
}

