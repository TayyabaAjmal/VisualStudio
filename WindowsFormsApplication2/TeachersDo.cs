using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication2
{
    class TeachersDo:Employee
    {
        public string Err, qualification,alerts;
        public int salary;
        public DataTable Table;


        //add a record
        public void AddRecords()
        {
            string sqlText = "SELECT (*) FROM Teachers";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Teachers VALUES(@i,@n,@d,@ad,@pn,@mn,@doj,@wh,'Teacher',@qual,@sal)", sqlConn);
                da.InsertCommand.Parameters.Add("@i", SqlDbType.Int).Value = id;
                da.InsertCommand.Parameters.Add("@n", SqlDbType.Text).Value = name;
                da.InsertCommand.Parameters.Add("@d", SqlDbType.Text).Value = designation;
                da.InsertCommand.Parameters.Add("@ad", SqlDbType.Text).Value = address;
                da.InsertCommand.Parameters.Add("@pn", SqlDbType.Int).Value = phone;
                da.InsertCommand.Parameters.Add("@mn", SqlDbType.Int).Value = mphone;
                da.InsertCommand.Parameters.Add("@doj", SqlDbType.Text).Value = dateofjoining;
                da.InsertCommand.Parameters.Add("@wh", SqlDbType.Text).Value = whours;
               
                da.InsertCommand.Parameters.Add("@qual", SqlDbType.Text).Value = qualification;
                da.InsertCommand.Parameters.Add("@sal", SqlDbType.Int).Value = salary;


                sqlConn.Open();
                da.InsertCommand.ExecuteNonQuery();
                sqlConn.Close();
                Err = "Success!";

            }


            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    Err = "Id Duplication";
                }
                else throw;
            }

        }

        //remove a record by  id
        public void RemoveRecord(int id_p)
        {

            string sqlText = "SELECT (*) FROM Teachers";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("DELETE FROM Teachers WHERE Id = " + id_p, sqlConn);

                sqlConn.Open();
                da.InsertCommand.ExecuteNonQuery();
                sqlConn.Close();
                Err = "Success!";
            }
            catch
            {
                Err = "No record exists";
            }
        }
            //find by id

            public void FindByID(int id_passed, DataTable table_p)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Teachers WHERE Id = " + id_passed, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(table_p);

              
            }
            catch
            {
                Err = "No Record exists";
            }
           
        }

            public void showAll()
            {
                SqlConnection conn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");
                SqlCommand sql = new SqlCommand();
                SqlDataAdapter adpt;
                Table = new DataTable();
                adpt = new SqlDataAdapter("SELECT Id, Name, Designation, Address, PhoneNo, MobileNo, WorkingHours, DateOfJoining, Qualification, Salary FROM Teachers", conn);
                adpt.Fill(Table);

            }
        public void showAlerts(int id_passed)
            {
                string fileName = Convert.ToString(id_passed);
                FileInfo filetoappend = new FileInfo(fileName);
                using (StreamWriter sw = filetoappend.AppendText())
                {
                   

                }
                // Read all text
                string readText = File.ReadAllText(fileName);
                alerts = readText;
            }
    }
}
