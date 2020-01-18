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
    public partial class frmStudentAdd : Form
    {
        StudentDo Manager = new StudentDo();
        public frmStudentAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                Manager.id = Convert.ToInt32(textBox1.Text);
                Manager.name = textBox2.Text;
                Manager.classs = textBox3.Text;
                Manager.address = textBox4.Text;
                Manager.phoneno = Convert.ToInt32(textBox5.Text);
                Manager.mobileno = Convert.ToInt32(textBox6.Text);
                Manager.admissiondate = textBox7.Text;
                Manager.comments = textBox8.Text;
                Manager.previousmarks = Convert.ToInt32(textBox9.Text);

                Manager.AddStudent();
                MessageBox.Show(Manager.Err);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
