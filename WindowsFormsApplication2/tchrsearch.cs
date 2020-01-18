
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
namespace WindowsFormsApplication2
{
   
    public partial class tchrsearch : Form
    {
        string Err;
        public tchrsearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeachersDo emp = new TeachersDo();
            //Removing the record
            emp.RemoveRecord(Convert.ToInt32(textBox1.Text));
            //Updating the record

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox11.Text != "" && textBox12.Text != "") 
            {
                emp.id = Convert.ToInt32(textBox1.Text);
                emp.name = textBox2.Text;
                emp.designation = textBox3.Text;
                emp.address = textBox4.Text;
                emp.phone = Convert.ToInt32(textBox5.Text);
                emp.mphone = Convert.ToInt32(textBox6.Text);
                emp.whours = textBox7.Text;
                emp.dateofjoining = textBox8.Text;
                emp.qualification = textBox11.Text;
                emp.salary = Convert.ToInt32(textBox12.Text);

                emp.accounttype = "Teacher";
                emp.AddRecords();
                if (emp.Err == "Id Duplication") { MessageBox.Show("Id already Exists"); }
                else
                {
                    MessageBox.Show("Updated");
                }
              
            }
            else { MessageBox.Show("Enter all the fields"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a=0;
            int b=0;
            int c = 0;
            int d=0;

            DataTable Data = new DataTable();
            TeachersDo Manager = new TeachersDo();

            Manager.FindByID(Convert.ToInt32(textBox10.Text),Data);
            foreach (DataRow dr in Data.Rows)
            {
                
                    a = Convert.ToInt32(dr["Id"]);
                    b = Convert.ToInt32(dr["MobileNo"]);
                    c = Convert.ToInt32(dr["PhoneNo"]);
                    d = Convert.ToInt32(dr["Salary"]);
                    
            
                textBox1.Text = Convert.ToString(a);
               textBox2.Text = dr["Name"].ToString();
                textBox3.Text = dr["Designation"].ToString();
                textBox4.Text = dr["Address"].ToString();
                textBox5.Text = Convert.ToString(b);
                textBox6.Text = Convert.ToString(c);
                textBox7.Text = dr["WorkingHours"].ToString();
              textBox8.Text= dr["DateOfJoining"].ToString();

         
            
               
               textBox11.Text = dr["Qualification"].ToString();
               textBox12.Text = Convert.ToString(d);

                Err = "Success!";

            }
            if (a == 0)
            {
                MessageBox.Show("No record found");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        }
    }
