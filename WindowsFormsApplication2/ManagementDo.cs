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
    class Management:Employee
    {
        public string Err;
        public DataTable Table;
        
        public void AddRecords()
        {
            string sqlText = "SELECT (*) FROM Employees";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Employees VALUES(@i,@n,@d,@ad,@pn,@mn,@doj,@wh,@at,'','')", sqlConn);
                da.InsertCommand.Parameters.Add("@i", SqlDbType.Int).Value = id;
                da.InsertCommand.Parameters.Add("@n", SqlDbType.Text).Value = name;
                da.InsertCommand.Parameters.Add("@d", SqlDbType.Text).Value = designation;
                da.InsertCommand.Parameters.Add("@ad", SqlDbType.Text).Value =address;
                da.InsertCommand.Parameters.Add("@pn", SqlDbType.Int).Value = phone;
                da.InsertCommand.Parameters.Add("@mn", SqlDbType.Int).Value = mphone;
                da.InsertCommand.Parameters.Add("@doj", SqlDbType.Text).Value = dateofjoining;
                da.InsertCommand.Parameters.Add("@wh", SqlDbType.Text).Value = whours;
                da.InsertCommand.Parameters.Add("@at", SqlDbType.Text).Value = accounttype;
                
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


        public void RemoveRecord(int id_p)
        {

            string sqlText = "SELECT (*) FROM Employees";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("DELETE FROM Employees WHERE Id = " + id_p, sqlConn);

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

        public void FindByID(int id_passed, Employee vars)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE Id = " + id_passed, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    vars.id = Convert.ToInt32(dr["Id"].ToString());
                    vars.name = dr["Name"].ToString();
                    vars.designation = dr["Designation"].ToString();
                    vars.address = dr["Address"].ToString();
                    vars.dateofjoining = dr["DateOfJoining"].ToString();
                    vars.accounttype = dr["AccountType"].ToString();
                    vars.mphone = Convert.ToInt32(dr["MobileNo"].ToString());
                    vars.phone = Convert.ToInt32(dr["PhoneNo"].ToString());
                    vars.whours = dr["WorkingHours"].ToString();
                    Err = "Success!";

                }
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
            adpt = new SqlDataAdapter("SELECT Id, Name, Designation, Address, PhoneNo, MobileNo, WorkingHours, DateOfJoining FROM Employees", conn);
            adpt.Fill(Table);

        }


        public void sendAlert(int id_ofteacher, string message)
        {
            string fileName = Convert.ToString(id_ofteacher);
            FileInfo filetoappend = new FileInfo(fileName);
            using (StreamWriter sw = filetoappend.AppendText())
            {
                sw.WriteLine(message);
                sw.WriteLine("------------------------------");

            }
            // Read all text
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
        }

        }



    }






