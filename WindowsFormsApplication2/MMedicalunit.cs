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
    public class Medicalunit : Pfacilities
    {
        public string pname, Err;
        public int pid;
        public string medicines;
        public int availableDoc;
        public int age;
        public string disease;
        public DataTable Table = new DataTable();
        public void AddRecords()
        {
            string sqlText = "SELECT (*) FROM Medicalunit";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Medicalunit VALUES(@pn,@pi,@m,@ad,@a,@d,@mc,@mg,@i)", sqlConn);
                da.InsertCommand.Parameters.Add("@pn", SqlDbType.Text).Value = pname;
                da.InsertCommand.Parameters.Add("@pi", SqlDbType.Int).Value = pid;
                da.InsertCommand.Parameters.Add("@m", SqlDbType.Text).Value = medicines;
                da.InsertCommand.Parameters.Add("@ad", SqlDbType.Int).Value = availableDoc;
                da.InsertCommand.Parameters.Add("@a", SqlDbType.Int).Value = age;
                da.InsertCommand.Parameters.Add("@d", SqlDbType.Text).Value = disease;
                da.InsertCommand.Parameters.Add("@mc", SqlDbType.Text).Value = maintainance;
                da.InsertCommand.Parameters.Add("@mg", SqlDbType.Text).Value = management;
                da.InsertCommand.Parameters.Add("@i", SqlDbType.Text).Value = issues;

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
            adpt = new SqlDataAdapter("SELECT pname, pid, medicines, availabledoc, age, disease, Maintainence, Management, Issues FROM Medicalunit", conn);
            adpt.Fill(Table);

        }

    }

}
