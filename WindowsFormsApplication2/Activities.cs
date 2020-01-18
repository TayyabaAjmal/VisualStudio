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
    class Activities 
    {
        public string art, dramaclub, music, sports, Err;


        public DataTable Table;
        public void add()
        {
            string sqlText = "SELECT (*) FROM Activities";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Activities VALUES(@a,@d,@m,@s)", sqlConn);
                da.InsertCommand.Parameters.Add("@a", SqlDbType.Text).Value = art;
                da.InsertCommand.Parameters.Add("@d", SqlDbType.Text).Value = dramaclub;
                da.InsertCommand.Parameters.Add("@m", SqlDbType.Text).Value = music;
                da.InsertCommand.Parameters.Add("@s", SqlDbType.Text).Value = sports;
               
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
            adpt = new SqlDataAdapter("SELECT art, dramaclub, music, sports FROM Activities", conn);
            adpt.Fill(Table);

        }


    }
}
