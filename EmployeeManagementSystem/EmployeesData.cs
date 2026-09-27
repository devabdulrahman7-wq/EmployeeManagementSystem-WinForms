using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmployeesData
    {
       public int id { get; set; }
        public string EmployeeID { get; set; }
       

        public string fullname { get; set; }
        //public string gender { get; set; }
        //public string contactno { get; set; }
        public string position { get; set; }
        public int salary { get; set; }
        //public string image { get; set; }
        //public string status { get; set; }

        public List<EmployeesData>  employeesListData()
        {
            string connstring = "server=localhost;user id=root;password=;database=employee";
            MySqlConnection connect = new MySqlConnection(connstring);
            List<EmployeesData> listdata = new List<EmployeesData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM `employeeinfo` WHERE delete_date IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeesData ed = new EmployeesData();
                           ed.id = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.fullname = reader["full_name"].ToString();
                          //  ed.gender = reader["gender"].ToString();
                           // ed.contactno = reader["contact_number"].ToString();
                            ed.position = reader["position"].ToString();
                           // ed.image = reader["image"].ToString();
                            ed.salary = (int)reader["salary"];
                          //  ed.status = reader["status"].ToString();
                            listdata.Add(ed);
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
        
    
    