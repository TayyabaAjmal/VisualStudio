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
    public partial class frmaddteacher : Form
    {
        public frmaddteacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management emp = new Management();
            if (textBox1.Text !="" && textBox2.Text !="" && textBox3.Text !="" && textBox4.Text !="" && textBox5.Text !="" && textBox6.Text !="" && textBox7.Text !="" && textBox8.Text !="")
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
                    MessageBox.Show("Signed Up, You can now login");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
