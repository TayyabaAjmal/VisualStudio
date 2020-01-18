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
    public class Security : Pfacilities
    {

        public int noofCameras;
        public string areasCovered, Err;
        public string controlrooms;

        public DataTable Table = new DataTable();
        public void AddRecords()
        {
            string sqlText = "SELECT (*) FROM Security";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Security VALUES(@c,@a,@cr)", sqlConn);
                da.InsertCommand.Parameters.Add("@c", SqlDbType.Text).Value = noofCameras;
                da.InsertCommand.Parameters.Add("@a", SqlDbType.Text).Value = areasCovered;
                da.InsertCommand.Parameters.Add("@cr", SqlDbType.Text).Value = controlrooms;
                

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
            adpt = new SqlDataAdapter("SELECT noofcameras, areascovered, controlrooms FROM Security", conn);
            adpt.Fill(Table);

        }

    }

}
