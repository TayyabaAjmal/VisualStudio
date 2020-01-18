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
    class Accounts
    {
        public string sname,section,tname,otherexpense,unpaidfee,Err;
    
        public int sfee, tsalary;
        public DataTable Table;
        public void add()
        {
        string sqlText = "SELECT (*) FROM Accounts";
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=PCAFA9\\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True");

                SqlCommand command = new SqlCommand(sqlText, sqlConn);


                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Accounts VALUES(@sn,@s,@tn,@oe,@uf,@sf,@ts)", sqlConn);
                da.InsertCommand.Parameters.Add("@sn", SqlDbType.Text).Value = sname;
                da.InsertCommand.Parameters.Add("@s", SqlDbType.Text).Value = section;
                da.InsertCommand.Parameters.Add("@tn", SqlDbType.Text).Value = tname;
                da.InsertCommand.Parameters.Add("@oe", SqlDbType.Text).Value =otherexpense;
                da.InsertCommand.Parameters.Add("@uf", SqlDbType.Text).Value = unpaidfee;
                da.InsertCommand.Parameters.Add("@sf", SqlDbType.Int).Value = sfee;
                da.InsertCommand.Parameters.Add("@ts", SqlDbType.Int).Value = tsalary;
             
                
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
            adpt = new SqlDataAdapter("SELECT sname, section, tname, otherexpense, unpaidfee, sfee, tsalary FROM Accounts", conn);
            adpt.Fill(Table);

        }


    }
    }

