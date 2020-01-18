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
    class StudentDo
    {
        public string name, classs, address, admissiondate, comments;
        public string Err;
        public int id, phoneno, mobileno, previousmarks;
      public DataTable Table;
    public void AddStudent()
        {
            string sqlText = "SELECT (*) FROM Students";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Students VALUES(@i,@n,@c,@ad,@pn,@mn,@add,@com,@pm)", sqlConn);
                da.InsertCommand.Parameters.Add("@i", SqlDbType.Int).Value = id;
                da.InsertCommand.Parameters.Add("@n", SqlDbType.Text).Value = name;
                da.InsertCommand.Parameters.Add("@c", SqlDbType.Text).Value = classs;
                da.InsertCommand.Parameters.Add("@ad", SqlDbType.Text).Value = address;
                da.InsertCommand.Parameters.Add("@pn", SqlDbType.Int).Value = phoneno;
                da.InsertCommand.Parameters.Add("@mn", SqlDbType.Int).Value = mobileno;
                da.InsertCommand.Parameters.Add("@add", SqlDbType.Text).Value = admissiondate;
                da.InsertCommand.Parameters.Add("@com", SqlDbType.Text).Value =comments ;
                da.InsertCommand.Parameters.Add("@pm", SqlDbType.Int).Value = previousmarks ;

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

        string sqlText = "SELECT (*) FROM Students";
        try
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

            SqlCommand command = new SqlCommand(sqlText, sqlConn);


            SqlDataAdapter da = new SqlDataAdapter();

            da.InsertCommand = new SqlCommand("DELETE FROM Students WHERE Id = " + id_p, sqlConn);

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

    public void FindByID(int id_passed, DataTable table_p)
    {
        try
        {
            SqlConnection conn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Id = " + id_passed, conn);
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
        adpt = new SqlDataAdapter("SELECT * FROM Students", conn);
        adpt.Fill(Table);

    }
   



    }

       
}
