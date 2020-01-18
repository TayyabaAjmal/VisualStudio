using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmStudentFind : Form
    {
        public FrmStudentFind()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            DataTable Data = new DataTable();
            StudentDo Manager = new StudentDo ();

            Manager.FindByID(Convert.ToInt32(textBox10.Text), Data);
            foreach (DataRow dr in Data.Rows)
            {

                a = Convert.ToInt32(dr["Id"]);
                b = Convert.ToInt32(dr["MobileNo"]);
                c = Convert.ToInt32(dr["PhoneNo"]);
                d = Convert.ToInt32(dr["PreviousMarks"]);


                textBox1.Text = Convert.ToString(a);
                textBox2.Text = dr["Name"].ToString();
                textBox3.Text = dr["Class"].ToString();
                textBox4.Text = dr["Address"].ToString();
                textBox5.Text = Convert.ToString(b);
                textBox6.Text = Convert.ToString(c);
                textBox7.Text = dr["AdmissionDate"].ToString();
                textBox8.Text = dr["CommentsByClassTeacher"].ToString();
                textBox9.Text = Convert.ToString(d);

                Manager.Err = "Success!";
                MessageBox.Show(Manager.Err);

            }
            if (a == 0)
            {
                MessageBox.Show("No record found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDo emp = new StudentDo();
            //Removing the record
            emp.RemoveRecord(Convert.ToInt32(textBox1.Text));
            //Updating the record

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                emp.id = Convert.ToInt32(textBox1.Text);
                emp.name = textBox2.Text;
                emp.classs = textBox3.Text;
                emp.address = textBox4.Text;
                emp.phoneno = Convert.ToInt32(textBox5.Text);
                emp.mobileno = Convert.ToInt32(textBox6.Text);
                emp.admissiondate = textBox7.Text;
                emp.comments = textBox8.Text;
                emp.previousmarks = Convert.ToInt32(textBox9.Text);
           
                emp.AddStudent();
                if (emp.Err == "Id Duplication") { MessageBox.Show("Id already Exists"); }
                else
                {
                    MessageBox.Show("Updated");
                }

            }
            else { MessageBox.Show("Enter all the fields"); }
        }
    }
}
