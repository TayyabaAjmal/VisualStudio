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
    public partial class AllTay : Form
    {
        Accounts Acc = new Accounts();
        Activities Act = new Activities();
        onlinePayment Op = new onlinePayment();
        Transport Tp = new Transport();
        public AllTay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Acc.sname = textBox1.Text;
                Acc.section = textBox2.Text;
                Acc.tname = textBox3.Text;
                Acc.otherexpense = textBox4.Text;
                Acc.unpaidfee = textBox5.Text;
                Acc.sfee = Convert.ToInt32(textBox6.Text);
                Acc.tsalary = Convert.ToInt32(textBox7.Text);

                Act.art = textBox15.Text;
                Act.dramaclub = textBox11.Text;
                Act.music = textBox10.Text;
                Act.sports = textBox16.Text;

                Tp.NoOfbuses = Convert.ToInt32(textBox14.Text);
                Tp.NoOfstudents = Convert.ToInt32(textBox13.Text);
                Tp.busRoute = textBox12.Text;

                Op.bankname = textBox21.Text;
                Op.accNum = Convert.ToInt32(textBox20.Text);

                Acc.add();
                Act.add();
                Op.add();
                Tp.add();
                MessageBox.Show("Saved!");
            }
            catch
            {
                MessageBox.Show("Error Saving");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AllTay_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            Acc.showAll();
            dataGridView1.DataSource = Acc.Table;
            Act.showAll();
            dataGridView2.DataSource = Act.Table;
            Op.showAll();
            dataGridView4.DataSource = Op.Table;
            Tp.showAll();
            dataGridView3.DataSource = Tp.Table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
