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
    class onlinePayment : Accounts
    {
        public string bankname, Err;
        public int accNum;
        DataTable Table = new DataTable();
        public void add()
        {
            string sqlText = "SELECT (*) FROM OnlinePayment";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO OnlinePayment VALUES(@b,@a)", sqlConn);
                da.InsertCommand.Parameters.Add("@b", SqlDbType.Text).Value = bankname;
                da.InsertCommand.Parameters.Add("@a", SqlDbType.Int).Value = accNum;
          

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
            adpt = new SqlDataAdapter("SELECT Bankname, Accountno FROM OnlinePayment", conn);
            adpt.Fill(Table);

        }


    }
}
