using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          


        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmaddteacher frmadd = new frmaddteacher();
            Form1 imee = new Form1();
            imee.Hide();
            frmadd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtrem.Visible == false)
            {
                txtrem.Visible = true;

            }
            else
            {
                Management Manager = new Management();
                Manager.RemoveRecord(Convert.ToInt32(txtrem.Text));
                MessageBox.Show(Manager.Err);
                txtrem.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 findshow = new Form3();
            findshow.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmshowallM show = new frmshowallM();
            show.Show();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAlert Alert = new frmAlert();
            Alert.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmTAdsd frm = new FrmTAdsd();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                textBox1.Visible = true;

            }
            else
            {
                TeachersDo Manager = new TeachersDo();
                Manager.RemoveRecord(Convert.ToInt32(textBox1.Text));
                MessageBox.Show(Manager.Err);
                textBox1.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tchrsearch Search = new tchrsearch();
            Search.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmshowallt frm = new frmshowallt();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmTeacherAlert frm = new frmTeacherAlert();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmStudentAdd Frm = new frmStudentAdd();
            Frm.Show();
            Management manager = new Management();
        

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                textBox2.Visible = true;

            }
            else
            {
                StudentDo Manager = new StudentDo();
                Manager.RemoveRecord(Convert.ToInt32(textBox2.Text));
                MessageBox.Show(Manager.Err);
                textBox2.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmStudentFind frm = new FrmStudentFind();
            frm.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmshowallstudents frm = new frmshowallstudents();
            frm.Show();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            AllTay tay = new AllTay();
            tay.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Allmay frm = new Allmay();
            frm.Show();

        }

}
        }
    

