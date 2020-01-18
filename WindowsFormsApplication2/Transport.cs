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
    class Transport
    {
        public int NoOfbuses;
        public int NoOfstudents;
        public string busRoute, Err;

        public DataTable Table = new DataTable();
        public void add()
        {
            string sqlText = "SELECT (*) FROM Transport";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Transport VALUES(@b,@s,@r)", sqlConn);
                da.InsertCommand.Parameters.Add("@r", SqlDbType.Text).Value = busRoute;
                da.InsertCommand.Parameters.Add("@b", SqlDbType.Int).Value = NoOfbuses;
                da.InsertCommand.Parameters.Add("@s", SqlDbType.Int).Value = NoOfstudents;

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

        public void showAll()
        {
            SqlConnection conn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");
            SqlCommand sql = new SqlCommand();
            SqlDataAdapter adpt;
            Table = new DataTable();
            adpt = new SqlDataAdapter("SELECT noOfbuses, noOfStudents, busRoute FROM Transport", conn);
            adpt.Fill(Table);

        }


    }
}
