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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Management Manager = new Management();
            Employee Store = new Employee();
            int id_s = Convert.ToInt32(textBox10.Text);
            Manager.FindByID(id_s,Store);
            textBox1.Text =Convert.ToString(Store.id);
            textBox2.Text = Store.name;
            textBox3.Text = Store.designation;
            textBox4.Text = Store.address;
            textBox5.Text = Convert.ToString(Store.phone);
            textBox6.Text = Convert.ToString(Store.mphone);
            textBox7.Text = Convert.ToString(Store.whours);
            textBox8.Text = Convert.ToString(Store.dateofjoining);









           if (Store.id == 0)
           {
               MessageBox.Show("No record found");
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management emp = new Management();
            //Removing the record
            emp.RemoveRecord(Convert.ToInt32(textBox1.Text));
            //Updating the record
           
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                emp.id = Convert.ToInt32(textBox1.Text);
                emp.name = textBox2.Text;
                emp.designation = textBox3.Text;
                emp.address = textBox4.Text;
                emp.phone = Convert.ToInt32(textBox5.Text);
                emp.mphone = Convert.ToInt32(textBox6.Text);
                emp.whours = textBox7.Text;
                emp.dateofjoining = textBox8.Text;
               emp.accounttype = "Management"; 
                emp.AddRecords();
                if (emp.Err == "Id Duplication") { MessageBox.Show("Id already Exists"); }
                else
                {
                    MessageBox.Show("Updated");
                }
            }
        }
    }
}
