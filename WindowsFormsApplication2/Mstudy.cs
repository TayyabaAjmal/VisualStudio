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
   public class study :Pfacilities
    {
        public string lab;
        public string lib;
        public int libhours;
        public string recordOfIssuedBooks, Err;
        public int NoofLibrarians;
        public int labhours;
        public int systems;
        public int labattenders;
        public DataTable Table = new DataTable();
        public void AddRecords()
        {
            string sqlText = "SELECT (*) FROM Study";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Study VALUES(@l,@li,@lh,@ib,@nl,@labh,@sys,@la)", sqlConn);
                da.InsertCommand.Parameters.Add("@l", SqlDbType.Text).Value = lab;
                da.InsertCommand.Parameters.Add("@li", SqlDbType.Text).Value =lib ;
                da.InsertCommand.Parameters.Add("@lh", SqlDbType.Int).Value = libhours;
                da.InsertCommand.Parameters.Add("@ib", SqlDbType.Text).Value = recordOfIssuedBooks;
                da.InsertCommand.Parameters.Add("@nl", SqlDbType.Int).Value = NoofLibrarians;
                da.InsertCommand.Parameters.Add("@labh", SqlDbType.Int).Value = labhours;
                da.InsertCommand.Parameters.Add("@sys", SqlDbType.Int).Value = systems;
                da.InsertCommand.Parameters.Add("@la", SqlDbType.Int).Value = labattenders;
  

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
            adpt = new SqlDataAdapter("SELECT lab, lib, libhours, recordofissuedbooks, nooflibrarians, labhours, systems, labattenders FROM Study", conn);
            adpt.Fill(Table);

        }

    }

}
